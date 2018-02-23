using System;
using TeleBotMessenger.Helper;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace TeleBotMessenger.Core.Telegram
{
    public class BotKeyboardCollection
    {
        public IReplyMarkup GetCancelInlineKeyboard()
        {
            var inlineKeys = new InlineKeyboardMarkup(new[]
            {
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardCallbackButton(Emoji.CrossMarkButton + "Cancel", "Cancel")
                }
            });

            return inlineKeys;
        }

        public IReplyMarkup GetAreYouSureInlineKeyboard()
        {
            var inlineKeys = new InlineKeyboardMarkup(new[]
            {
                new InlineKeyboardButton[]
                {
                    new InlineKeyboardCallbackButton("yes", "yes"),
                    new InlineKeyboardCallbackButton("no", "no")
                }
            });

            return inlineKeys;
        }
    }
}