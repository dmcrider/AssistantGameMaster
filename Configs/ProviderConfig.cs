using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Configs
{
    public class ProviderConfig : IProviderConfig
    {
        public string ProviderName { get; set; }
        public string ModelName { get; set; }

        public ProviderConfig()
        {
            ProviderName = string.Empty;
            ModelName = string.Empty;
        }

        public ProviderConfig(string providerName, string modelName)
        {
            ProviderName = providerName;
            ModelName = modelName;
        }

        public static ProviderConfig FromString(string data)
        {
            var parts = data.Split(',');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid data format.");
            }

            return new ProviderConfig(parts[0], parts[1]);
        }

        public override string ToString()
        {
            return $"{ProviderName},{ModelName}";
        }
    }
}
