using AssistantGameMaster.Data;
using AssistantGameMaster.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.FileHandler
{
    internal class FileHandler
    {
        public static FileHandler Instance { get; } = new FileHandler();
        private readonly string _defaultPath;

        private FileHandler()
        {
            _defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Assembly.GetExecutingAssembly().GetName().Name ?? "AssistantGameMaster");
            Directory.CreateDirectory(_defaultPath); // Will skip if it already exists
        }

        public void SaveChat(ICampaignConfig config, List<AppMessage> chatHistory)
        {
            ArgumentNullException.ThrowIfNull(config);

            var sorted = chatHistory.OrderBy(x => x.TimeStamp).ToList();
            var chatTimestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            var path = Path.Combine(config.SavePath, $"{config.CampaignName}_chat_{chatTimestamp}.txt");

            File.WriteAllText(path, string.Join(Environment.NewLine, sorted.Select(x => x.ToString())));
        }
    }
}
