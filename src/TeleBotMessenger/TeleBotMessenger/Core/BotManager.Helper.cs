using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using TeleBotMessenger.Helper;
using TeleBotMessenger.Properties;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TeleBotMessenger.Core.Telegram
{
    // BotManager.Helper
    public partial class BotManager
    {
        //public static void StartTimeToAnswerCallBack(string user)
        //{
        //    user?.Data.LastRequestElapsedTime.Restart();
        //}

        //protected bool CanAnswerCallBack(string user)
        //{
        //    // after 14sec telegram don't permission to send answer to income callback queries
        //    return user?.Data.LastRequestElapsedTime?.IsRunning == true &&
        //           user.Data.LastRequestElapsedTime.ElapsedMilliseconds < MaxAnswerDurationMs;
        //}

        //public async Task AnswerCallbackQueryAsync(string user, string text = null, bool showAlert = false,
        //    string url = null, int cacheTime = 0)
        //{
        //    if (CanAnswerCallBack(user))
        //    {
        //        user.Data.LastRequestElapsedTime?.Stop();
        //        await Bot.AnswerCallbackQueryAsync(user.Data.LastCallBackQuery?.Id, text, showAlert, url, cacheTime);
        //    }
        //}

        //protected bool CanEditMessage(Message msg)
        //{
        //    if (msg == null) return false;
        //    return (DateTime.Now - msg.Date).TotalHours < 46; // edit or delete message limit to 48hours
        //}

        //public async Task DeleteMessageAsync(Message msg)
        //{
        //    if (CanEditMessage(msg))
        //        await Bot.DeleteMessageAsync(msg.Chat.Id, msg.MessageId);
        //}
    }
}