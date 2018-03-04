using System;

namespace TeleBotMessenger.Model
{
    public class TelegramMessage
    {
        public Telegram.Bot.Types.Message Message { get; set; }

        public override string ToString()
        {
            return $"{Message.MessageId}: {Message.Text.Substring(0, Math.Min(10, Message.Text.Length))}";
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
