using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace TeleBotMessenger.Model
{
    public class TelegramMessage
    {
        public Telegram.Bot.Types.Message Message { get; set; }

        [JsonIgnore]
        public Image Photo { get; set; }

        public string Rtf { get; set; }

        public List<TelegramInlineUrlButton[]> Keyboard { get; set; }

        public override string ToString()
        {
            var text = Message.Text ?? Message.Caption;
            return $"{Message.Date:yyyy/M/d dddd hh:mm:ss}: {text.Substring(0, Math.Min(50, text.Length))}";

        }
    }
}
