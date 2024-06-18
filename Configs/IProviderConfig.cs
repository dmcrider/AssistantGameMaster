using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Configs
{
    internal interface IProviderConfig
    {
        public string ProviderName { get; set; }
        public string ModelName { get; set; }
    }
}
