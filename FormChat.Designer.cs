namespace AssistantGameMaster
{
    partial class FormChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            messagesToolStripMenuItem = new ToolStripMenuItem();
            chatHistoryToolStripMenuItem = new ToolStripMenuItem();
            newChatToolStripMenuItem = new ToolStripMenuItem();
            deleteChatToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            configureLLMToolStripMenuItem = new ToolStripMenuItem();
            configureCampaignDirectoryToolStripMenuItem = new ToolStripMenuItem();
            clearChatHistoryToolStripMenuItem = new ToolStripMenuItem();
            newCampaignToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            feedbackToolStripMenuItem = new ToolStripMenuItem();
            panelActiveChat = new Panel();
            txtUserMessage = new TextBox();
            btnSend = new Button();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, messagesToolStripMenuItem, settingsToolStripMenuItem, aboutToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1227, 24);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // messagesToolStripMenuItem
            // 
            messagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chatHistoryToolStripMenuItem, newChatToolStripMenuItem, deleteChatToolStripMenuItem });
            messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            messagesToolStripMenuItem.Size = new Size(70, 20);
            messagesToolStripMenuItem.Text = "&Messages";
            // 
            // chatHistoryToolStripMenuItem
            // 
            chatHistoryToolStripMenuItem.Name = "chatHistoryToolStripMenuItem";
            chatHistoryToolStripMenuItem.Size = new Size(140, 22);
            chatHistoryToolStripMenuItem.Text = "&Chat History";
            chatHistoryToolStripMenuItem.Click += ChatHistoryToolStripMenuItem_Click;
            // 
            // newChatToolStripMenuItem
            // 
            newChatToolStripMenuItem.Name = "newChatToolStripMenuItem";
            newChatToolStripMenuItem.Size = new Size(140, 22);
            newChatToolStripMenuItem.Text = "&New Chat";
            newChatToolStripMenuItem.Click += NewChatToolStripMenuItem_Click;
            // 
            // deleteChatToolStripMenuItem
            // 
            deleteChatToolStripMenuItem.Name = "deleteChatToolStripMenuItem";
            deleteChatToolStripMenuItem.Size = new Size(140, 22);
            deleteChatToolStripMenuItem.Text = "&Delete Chat";
            deleteChatToolStripMenuItem.Click += DeleteChatToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configureLLMToolStripMenuItem, configureCampaignDirectoryToolStripMenuItem, clearChatHistoryToolStripMenuItem, newCampaignToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "&Settings";
            // 
            // configureLLMToolStripMenuItem
            // 
            configureLLMToolStripMenuItem.Name = "configureLLMToolStripMenuItem";
            configureLLMToolStripMenuItem.Size = new Size(236, 22);
            configureLLMToolStripMenuItem.Text = "Configure &LLM";
            configureLLMToolStripMenuItem.Click += ConfigureLLMToolStripMenuItem_Click;
            // 
            // configureCampaignDirectoryToolStripMenuItem
            // 
            configureCampaignDirectoryToolStripMenuItem.Name = "configureCampaignDirectoryToolStripMenuItem";
            configureCampaignDirectoryToolStripMenuItem.Size = new Size(236, 22);
            configureCampaignDirectoryToolStripMenuItem.Text = "Configure Campaign &Directory";
            configureCampaignDirectoryToolStripMenuItem.Click += ConfigureCampaignDirectoryToolStripMenuItem_Click;
            // 
            // clearChatHistoryToolStripMenuItem
            // 
            clearChatHistoryToolStripMenuItem.Name = "clearChatHistoryToolStripMenuItem";
            clearChatHistoryToolStripMenuItem.Size = new Size(236, 22);
            clearChatHistoryToolStripMenuItem.Text = "&Clear Chat History";
            clearChatHistoryToolStripMenuItem.Click += ClearChatHistoryToolStripMenuItem_Click;
            // 
            // newCampaignToolStripMenuItem
            // 
            newCampaignToolStripMenuItem.Name = "newCampaignToolStripMenuItem";
            newCampaignToolStripMenuItem.Size = new Size(236, 22);
            newCampaignToolStripMenuItem.Text = "&New Campaign";
            newCampaignToolStripMenuItem.Click += NewCampaignToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versionToolStripMenuItem, feedbackToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(153, 22);
            versionToolStripMenuItem.Text = "&Version";
            versionToolStripMenuItem.Click += VersionToolStripMenuItem_Click;
            // 
            // feedbackToolStripMenuItem
            // 
            feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            feedbackToolStripMenuItem.Size = new Size(153, 22);
            feedbackToolStripMenuItem.Text = "&Send Feedback";
            feedbackToolStripMenuItem.Click += FeedbackToolStripMenuItem_Click;
            // 
            // panelActiveChat
            // 
            panelActiveChat.AutoScroll = true;
            panelActiveChat.BorderStyle = BorderStyle.FixedSingle;
            panelActiveChat.Dock = DockStyle.Top;
            panelActiveChat.Location = new Point(0, 24);
            panelActiveChat.Name = "panelActiveChat";
            panelActiveChat.Size = new Size(1227, 684);
            panelActiveChat.TabIndex = 2;
            // 
            // txtUserMessage
            // 
            txtUserMessage.Dock = DockStyle.Left;
            txtUserMessage.Location = new Point(0, 708);
            txtUserMessage.Multiline = true;
            txtUserMessage.Name = "txtUserMessage";
            txtUserMessage.Size = new Size(1107, 116);
            txtUserMessage.TabIndex = 3;
            txtUserMessage.KeyDown += TxtUserMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Right;
            btnSend.Location = new Point(1113, 708);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(114, 116);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send\r\nCTRL+Enter";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += BtnSend_Click;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 824);
            Controls.Add(btnSend);
            Controls.Add(txtUserMessage);
            Controls.Add(panelActiveChat);
            Controls.Add(menuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Margin = new Padding(4);
            Name = "FormChat";
            Text = "Assistant Game Master - Chat";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem configureLLMToolStripMenuItem;
        private ToolStripMenuItem configureCampaignDirectoryToolStripMenuItem;
        private ToolStripMenuItem clearChatHistoryToolStripMenuItem;
        private ToolStripMenuItem newCampaignToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private ToolStripMenuItem feedbackToolStripMenuItem;
        private ToolStripMenuItem messagesToolStripMenuItem;
        private ToolStripMenuItem chatHistoryToolStripMenuItem;
        private ToolStripMenuItem newChatToolStripMenuItem;
        private ToolStripMenuItem deleteChatToolStripMenuItem;
        private Panel panelActiveChat;
        private TextBox txtUserMessage;
        private Button btnSend;
    }
}
