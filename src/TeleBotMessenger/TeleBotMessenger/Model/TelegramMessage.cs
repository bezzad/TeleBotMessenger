using System;
using System.Drawing;

namespace TeleBotMessenger.Model
{
    public class TelegramMessage
    {
        public Telegram.Bot.Types.Message Message { get; set; }

        public Image Photo { get; set; }

        public override string ToString()
        {
            var text = Message.Text ?? Message.Caption;
            return $"{Message.Date:yyyy/M/d dddd hh:mm:ss}: {text.Substring(0, Math.Min(50, text.Length))}";

        }

        public static TelegramMessage Factory(Telegram.Bot.Types.Message msg, Image photo = null)
        {
            return new TelegramMessage()
            {
                Message = msg,
                Photo = photo
            };
        }
    }
}
