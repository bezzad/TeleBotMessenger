using System;
using System.Collections.Generic;

namespace TeleBotMessenger.Core.Telegram
{
    // BotManager.CallbackMission
    public partial class BotManager
    {
        protected void OnInlineKeySetting()
        {
            //if (user?.Data.LastCallBackQuery == null)
            //    return;

            //if (user.Data.SettingMessage?.MessageId != user.Data.LastCallBackQuery.Message.MessageId ||
            //    !CanEditMessage(user.Data.LastCallBackQuery.Message)) // if the setting is old or expired
            //{
            //    await DeleteMessageAsync(user.Data.LastCallBackQuery.Message);
            //    if (user.Data.SettingMessage == null)
            //    {
            //        user.Data.SettingMessage = user.Data.LastMessage =
            //            await Bot.SendTextMessageAsync(user.Data.LastCallBackQuery.Message.Chat.Id,
            //                Localization.SettingTitle, ParseMode.Html,
            //                replyMarkup: KeyboardCollection.GetSettingInlineKeyboard(user.Data.Setting));

            //        user.Data.WaitingMessageQuery = Localization.Setting;
            //    }
            //    if (user.TelegramUserId.HasValue)
            //        await AnswerCallbackQueryAsync(user, Localization.SettingUpdated);

            //    return;
            //}

            //var propName = user.Data.LastCallBackQuery.Data.Replace(PrefixKeys.Setting, "");

            //var prop = user.Data.Setting.GetType().GetProperty(propName);
            //if (prop?.Name == nameof(user.Data.Setting.NewsletterDaysPeriod))
            //{
            //    var val = (int)prop.GetValue(user.Data.Setting);
            //    user.Data.Setting.NewsletterDaysPeriod = val >= 30 ? 1 : val >= 7 ? 30 : 7;
            //}
            //else if (prop != null)
            //{
            //    prop.SetValue(user.Data.Setting, !(bool)prop.GetValue(user.Data.Setting));
            //}
            //else
            //{
            //    return;
            //}

            //await Context.SetNewsletterSettingAsync(user.Data.Setting);

            //user.Data.LastCallBackQuery.Message =
            //    await Bot.EditMessageReplyMarkupAsync(user.Data.LastCallBackQuery.Message.Chat.Id,
            //        user.Data.LastCallBackQuery.Message.MessageId,
            //        KeyboardCollection.GetSettingInlineKeyboard(user.Data.Setting));

            //if (user.TelegramUserId.HasValue)
            //    await AnswerCallbackQueryAsync(user, Localization.SettingStored);
        }
        
    }
}