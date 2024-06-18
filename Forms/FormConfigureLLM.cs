using AssistantGameMaster.Configs;
using AssistantGameMaster.Data;
using AssistantGameMaster.Handlers;
using OpenAI.Chat;

namespace AssistantGameMaster.Forms
{
    public partial class FormConfigureLLM : Form
    {
        private static readonly string[] _supportedProviders = ["OpenAI"]; // Add others here as we add support
        private string _selectedModel = string.Empty;
        public ChatClient? OpenAIClient { get; private set; }

        public FormConfigureLLM()
        {
            InitializeComponent();
        }

        private void ConfigureLLM_Load(object sender, EventArgs e)
        {
            LoadProviders();
        }

        private void LoadProviders()
        {
            dropdownProvider.Items.Clear();
            dropdownProvider.Items.AddRange(_supportedProviders);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            OpenAIClient = null;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_selectedModel))
            {
                MessageBox.Show("Please select a model to use.", "No Model Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrEmpty(txtApiKey.Text))
            {
                MessageBox.Show("Please enter an API Key.", "Invalid API Key", MessageBoxButtons.OK);
            }

            var apiKey = txtApiKey.Text.Trim();
            if (!apiKey.StartsWith("sk-") || apiKey.Length != 56)
            {
                MessageBox.Show("Invalid API Key. Please enter a valid OpenAI API Key.", "Invalid API Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Security.SaveApiKey(apiKey);
            var config = new ProviderConfig(dropdownProvider.SelectedItem!.ToString()!, _selectedModel);
            FileHandler.Instance.SaveProviderConfig(config);
            OpenAIClient = new ChatClient(apiKey, _selectedModel);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DropdownProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dropdownProvider.SelectedItem == null)
            {
                return;
            }

            var provider = dropdownProvider.SelectedItem.ToString();
            switch(provider)
            {
                case "OpenAI":
                    LoadOpenAI();
                    break;
            }
        }

        private void DropdownModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownModels.SelectedItem == null || dropdownModels.SelectedItem is not OpenAIModel model)
            {
                return;
            }

            _selectedModel = model.ModelName;
        }

        private void LoadOpenAI()
        {
            dropdownModels.Items.Clear();
            // Got this from https://platform.openai.com/docs/models
            // We haven't configured the API Key at this point, so we can't call the endpoint to get the models
            var models = new List<OpenAIModel>()
            {
                new("gpt-4o", "Cheaper and faster than GPT-4 Turbo.", 128000),
                new("gpt-4-turbo", "The latest GPT-4 Turbo model with vision capabilities. Vision requests can now use JSON mode and function calling.",128000),
                new("gpt-4", "The base GPT-4 model. Not trained since September 2021.", 8192),
                new("gpt-3.5-turbo", "The latest GPT-3.5 Turbo model with higher accuracy at responding in requested formats and a fix for a bug which caused a text encoding issue for non-English language function calls.", 16385),
                new("dall-e-3", "The latest DALL·E model released in Nov 2023.",0),
                new("tts-1", "The latest text-to-speech model, optimized for speed", 0),
                new("tts-1-hd", "The latest text-to-speech model, optimized for quality", 0),
            };

            dropdownModels.Items.AddRange(models.ToArray());
        }
    }
}
