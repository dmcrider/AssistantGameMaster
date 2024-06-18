namespace AssistantGameMaster.Forms
{
    partial class FormConfigureLLM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigureLLM));
            dropdownProvider = new ComboBox();
            lblSelectProvider = new Label();
            lblModel = new Label();
            dropdownModels = new ComboBox();
            lblApiKey = new Label();
            txtApiKey = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // dropdownSelectLLM
            // 
            dropdownProvider.FormattingEnabled = true;
            dropdownProvider.Items.AddRange(new object[] { "OpenAI", "<Others Coming Soon>" });
            dropdownProvider.Location = new Point(147, 34);
            dropdownProvider.Name = "dropdownSelectLLM";
            dropdownProvider.Size = new Size(151, 29);
            dropdownProvider.TabIndex = 0;
            dropdownProvider.SelectedIndexChanged += DropdownProvider_SelectedIndexChanged;
            // 
            // lblSelectProvider
            // 
            lblSelectProvider.AutoSize = true;
            lblSelectProvider.Location = new Point(12, 37);
            lblSelectProvider.Name = "lblSelectProvider";
            lblSelectProvider.Size = new Size(129, 21);
            lblSelectProvider.TabIndex = 1;
            lblSelectProvider.Text = "Select a Provider:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(84, 80);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(57, 21);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model:";
            // 
            // dropdownModels
            // 
            dropdownModels.FormattingEnabled = true;
            dropdownModels.Location = new Point(147, 77);
            dropdownModels.Name = "dropdownModels";
            dropdownModels.Size = new Size(151, 29);
            dropdownModels.TabIndex = 3;
            dropdownModels.SelectedIndexChanged += DropdownModels_SelectedIndexChanged;
            // 
            // lblApiKey
            // 
            lblApiKey.AutoSize = true;
            lblApiKey.Location = new Point(76, 144);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(65, 21);
            lblApiKey.TabIndex = 4;
            lblApiKey.Text = "API Key:";
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(76, 168);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(473, 29);
            txtApiKey.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(440, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // ConfigureLLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 282);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtApiKey);
            Controls.Add(lblApiKey);
            Controls.Add(dropdownModels);
            Controls.Add(lblModel);
            Controls.Add(lblSelectProvider);
            Controls.Add(dropdownProvider);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ConfigureLLM";
            Text = "Configure LLM";
            Load += ConfigureLLM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox dropdownProvider;
        private Label lblSelectProvider;
        private Label lblModel;
        private ComboBox dropdownModels;
        private Label lblApiKey;
        private TextBox txtApiKey;
        private Button btnSave;
        private Button btnCancel;
    }
}