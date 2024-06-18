using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Data
{
    internal class OpenAIModel(string modelName, string modelDescription, int contextWindow)
    {
        public string ModelName { get; } = modelName;
        public string ModelDescription { get; } = modelDescription;
        public int ContextWindow { get; } = contextWindow;

        public override string ToString()
        {
            return ModelName;
        }
    }
}
