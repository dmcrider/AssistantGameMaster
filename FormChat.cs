using AssistantGameMaster.Data;
using AssistantGameMaster.Forms;
using AssistantGameMaster.Handlers;
using OpenAI.Chat;
using System.Reflection;
using System.Resources;

namespace AssistantGameMaster
{
    public partial class FormChat : Form
    {
        private readonly List<AppMessage> _chatHistory = [];
        private ChatClient? _chatClient;

        public FormChat()
        {
            InitializeComponent();
            // Check for an API key and configure the chat client
            if (Security.HasApiKey())
            {
                var config = FileHandler.Instance.GetProviderConfig();
                if(config.ProviderName == "OpenAI")
                {
                    _chatClient = new ChatClient(model: config.ModelName, credential: Security.GetApiKey());
                }
            }
            else
            {
                // No API key, show the configuration form
                ShowConfigureLLMForm();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var msg = txtUserMessage.Text.Trim();
            if (!string.IsNullOrEmpty(msg))
            {
                txtUserMessage.Clear();
                txtUserMessage.Enabled = false;
                btnSend.Enabled = false;

                AddChatMessage(msg, true);
                GetSystemMessage();

                txtUserMessage.Focus();
                txtUserMessage.Enabled = true;
                btnSend.Enabled = true;
            }
        }

        private int AddChatMessage(string message, bool isUserMessage)
        {
            var chatMessage = new AppMessage(message, isUserMessage);
            var lastLabel = panelActiveChat.Controls.Count > 0 ? panelActiveChat.Controls[0] as Label : null;

            var msgLabel = chatMessage.GetMessageBubble(panelActiveChat.ClientSize.Width);

            msgLabel.Text = message;

            // Add the label so we can get its correct size
            panelActiveChat.Controls.Add(msgLabel);
            msgLabel.BringToFront();

            // Then calculate the position
            var position = CalculateMessagePosition(msgLabel, lastLabel, isUserMessage);
            msgLabel.Location = position;

            panelActiveChat.ScrollControlIntoView(msgLabel);
            _chatHistory.Add(chatMessage);

            return panelActiveChat.Controls.IndexOf(msgLabel); // Return the index of the new label so the GetSystemMethod can update it
        }

        private void UpdateChatMessage(int index, string message)
        {
            var label = panelActiveChat.Controls[index] as Label;
            if(label != null)
            {
                label.Text = message;
            }
        }

        private void GetSystemMessage()
        {
            if(_chatClient == null)
            {
                MessageBox.Show("No chat client configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var history = new List<ChatMessage>
            {
                new SystemChatMessage(new ResourceManager("AssistantGameMaster.Properties.Resources", Assembly.GetExecutingAssembly()).GetString("SystemMessage"))
            };
            history.AddRange(_chatHistory.Select(x => x.ConvertToOpenAI()).ToList());

            var chatCompletion = _chatClient.CompleteChatStreaming(history);
            var response = string.Empty;
            var index = -1;
            foreach(var update in chatCompletion)
            {
                foreach(var updatePart in update.ContentUpdate)
                {
                    response += updatePart;
                    if(index < 0)
                    {
                        index = AddChatMessage(response, false);
                    }
                    else
                    {
                        UpdateChatMessage(index, response);
                    }
                    panelActiveChat.Invalidate();
                    Application.DoEvents();
                }
            }

        }

        private Point CalculateMessagePosition(Label newLabel, Label? lastLabel, bool isUserMessage)
        {
            int x = isUserMessage ? panelActiveChat.ClientSize.Width - newLabel.PreferredWidth - 20 : 10;
            int y = lastLabel != null ? lastLabel.Bottom + 10 : 10; // Start 10 pixels from the top if there's no last label
            return new Point(x, y);
        }

        private void TxtUserMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                BtnSend_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        #region ToolStripMenuItems
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveChat();
            Application.Exit();
        }

        private void ChatHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Chat History form
        }

        private void NewChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveChat();
            // Clear all chat messages
        }

        private void DeleteChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear all chat messages
        }

        private void ConfigureLLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConfigureLLMForm();
        }

        private void ConfigureCampaignDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Local File Configuration form
        }

        private void ClearChatHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm clearing chat history
            // Delete all chat history
        }

        private void NewCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt for name
            // Show the Local File Configuration form
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the version details
        }

        private void FeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the feedback form
        }
        #endregion

        private void ShowConfigureLLMForm()
        {
            var form = new FormConfigureLLM();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (form.OpenAIClient == null)
                {
                    MessageBox.Show("Failed to configure LLM model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _chatClient = form.OpenAIClient;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
