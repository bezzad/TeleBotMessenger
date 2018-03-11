using System;
using Telegram.Bot.Types.InlineKeyboardButtons;

namespace TeleBotMessenger.Model
{
    public class TelegramInlineUrlButton : InlineKeyboardUrlButton
    {
        public TelegramInlineUrlButton() : base(string.Empty, string.Empty)
        { }

        public TelegramInlineUrlButton(string text, string url) : base(text, url)
        { }

        public TelegramInlineUrlButton(string text, Uri url) : base(text, url)
        { }
    }
}