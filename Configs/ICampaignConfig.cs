using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Utilities
{
    internal interface ICampaignConfig
    {
        public string CampaignName { get; set; }
        public string SavePath { get; set; }
    }
}
