using System;

namespace TeleBotMessenger.Model
{
    public class TelegramMessage
    {
        public Telegram.Bot.Types.Message Message { get; set; }

        public override string ToString()
        {
            var text = Message.Text ?? Message.Caption;
            return $"{Message.MessageId}: {text.Substring(0, Math.Min(10, text.Length))}";
        }

        public static TelegramMessage Factory(Telegram.Bot.Types.Message msg)
        {
            return new TelegramMessage()
            {
                Message = msg
            };
        }
    }
}
