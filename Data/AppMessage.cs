using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Data
{
    internal class AppMessage(string message, bool isUserMessage)
    {
        public string Message { get; set; } = message;
        public bool IsUserMessage { get; set; } = isUserMessage;
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public Label GetLabel(int clientWidth)
        {
            var msgLabel = new Label
            {
                Text = Message,
                AutoSize = true,
                BackColor = IsUserMessage ? Color.LightBlue : Color.LightGreen,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Margin = new Padding(5),
                MaximumSize = new Size(clientWidth - 40, 0),
                TextAlign = IsUserMessage ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft
            };

            return msgLabel;
        }

        public override string ToString()
        {
            return $"[{TimeStamp:yyyy-MM-dd HH:mm:ss}] {(IsUserMessage ? "USER" : "SYSTEM")} | {Message.Trim()}";
        }
    }
}
