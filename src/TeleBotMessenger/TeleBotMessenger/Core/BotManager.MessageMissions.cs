using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TeleBotMessenger.Core.Telegram
{
    // BotManager.MessageMission
    public partial class BotManager
    {
        private void OnMessageReplyReceived()
        {
            //var replyMessage = user?.Data?.LastMessage?.ReplyToMessage;
            //if (replyMessage == null || !user.UserId.HasValue)
            //    return;

            //if (await Context.SetNewsletterReplyMessageAsync(user.UserId.Value, replyMessage.MessageId,
            //    comment: user.Data.LastMessage.Text))
            //    await Bot.SendTextMessageAsync(user.TelegramUserId, Localization.DeliverFeedbackMessage,
            //        replyMarkup: KeyboardCollection.GetCommonReplyKeyboard(user));
        }
        
        

        protected void OnMessageHelp()
        {
        //    await Bot.SendChatActionAsync(user.Data.LastMessage.Chat.Id, ChatAction.UploadPhoto);

        //    using (var stream = new MemoryStream(Resources.taaghchelogo.ToByte()))
        //    {
        //        await Bot.SendPhotoAsync(user.Data.LastMessage.Chat.Id, new FileToSend("about", stream), "راهنمای طاقچه",
        //            replyMarkup: KeyboardCollection.GetCommonReplyKeyboard(user));
        //    }

        //    var msgText =
        //        "این بات جهت ارسال خبرنامه‌های طاقچه ساخته شده است. " + Environment.NewLine +
        //        "خبرنامه‌ها برحسب تنظیمات شما ارسال می‌شود و " + 
        //        "شما می‌توانید تنظیمات مربوط به دریافت خبرنامه را هم از همین بات تغییر دهید." +
        //        Environment.NewLine + Environment.NewLine +
        //        Emoji.Gear + " تنظیمات خبرنامه:" + Environment.NewLine + Environment.NewLine;


        //    foreach (var attrib in user.Data.Setting.ConvertToArrayModel().Where(s => s.ItemConvertedType != SettingType.Url))
        //    {
        //        var defaultVal = attrib.AvailableValues == null ? ":" : $" ({string.Join("|", attrib.AvailableValues?.Values)}):";
        //        msgText += $"{Emoji.SmallBlueDiamond} {attrib.DisplayName}{defaultVal}\n{Emoji.LightBulb} {attrib.Description}\n\n";
        //    }

        //    msgText += Emoji.Feedback +
        //        " جهت ارسال بازخورد برای خبرنامه‌های دریافتی، می‌توانید برای خبرنامه مورد نظر پاسخ ارسال کنید." + 
        //        Environment.NewLine + Environment.NewLine + Emoji.BellWithSlash +
        //        $" در صورت عدم تمایل به دریافت خبرنامه از طریق تلگرام می‌توانید «{Localization.Unsubscribe}» را بزنید." +
        //        Environment.NewLine;

        //    user.Data.LastMessage = await Bot.SendTextMessageAsync(user.Data.LastMessage.Chat.Id, msgText, ParseMode.Html);
        }
        
    }
}