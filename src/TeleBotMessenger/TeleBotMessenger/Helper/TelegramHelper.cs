using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using TeleBotMessenger.Core;
using Telegram.Bot.Types;

namespace TeleBotMessenger.Helper
{
    public static class TelegramHelper
    {
        public static BotManager BotManager { get; set; }

        public static async Task<User> StartBot(string botApiKey)
        {
            BotManager = new BotManager(botApiKey);
            return await BotManager.StartListeningAsync();
        }

        public static byte[] ToByte(this Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static string GetStartLink(this User me, string startQuery)
        {
            return $"https://telegram.me/{me?.Username}/?start={startQuery}";
        }

        public static async Task<bool> IsRunning(this BotManager botManager)
        {
            if (botManager?.Bot == null || botManager?.BotApiKey == null || botManager?.Me?.IsBot != true)
                return false;

            var testApi = await botManager.Bot.TestApiAsync();
            var isReceiving = botManager.Bot.IsReceiving;
            var me = await botManager.Bot.GetMeAsync();

            return testApi && isReceiving && me?.IsBot == true && me.Id == botManager.Me.Id;
        }


    }
}