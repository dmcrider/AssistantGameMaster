using AssistantGameMaster.Data;

namespace AssistantGameMaster
{
    public partial class FormChat : Form
    {
        private readonly List<AppMessage> _chatHistory = [];

        public FormChat()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var msg = txtUserMessage.Text.Trim();
            if (!string.IsNullOrEmpty(msg))
            {
                AddChatMessage(msg, true);
                AddChatMessage("I'm sorry, I'm not yet connected to an LLM.", false);
                txtUserMessage.Clear();
                txtUserMessage.Focus();
            }
        }

        private void AddChatMessage(string message, bool isUserMessage)
        {
            var chatMessage = new AppMessage(message, isUserMessage);
            var lastLabel = panelActiveChat.Controls.Count > 0 ? panelActiveChat.Controls[0] as Label : null;

            var msgLabel = chatMessage.GetLabel(panelActiveChat.ClientSize.Width);

            // Add the label so we can get its correct size
            panelActiveChat.Controls.Add(msgLabel);
            msgLabel.BringToFront();

            // Then calculate the position
            var position = CalculateMessagePosition(msgLabel, lastLabel, isUserMessage);
            msgLabel.Location = position;

            panelActiveChat.ScrollControlIntoView(msgLabel);
            _chatHistory.Add(chatMessage);
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
            // Show the LLM Configuration form
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
    }
}
