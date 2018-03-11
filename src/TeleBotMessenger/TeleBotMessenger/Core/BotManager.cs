using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace TeleBotMessenger.Core
{
    // BotManager
    public partial class BotManager
    {
        public async Task<User> StartListeningAsync()
        {
            Bot = new TelegramBotClient(BotApiKey);
            Bot.StartReceiving();
            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived;
            Bot.OnInlineQuery += BotOnInlineQueryReceived;
            Bot.OnReceiveError += BotOnReceiveError;

            Me = await Bot.GetMeAsync();

            return Me;
        }

        private void BotOnInlineQueryReceived(object sender, InlineQueryEventArgs e)
        {
        }

        private void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs e)
        {
        }

        private void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
        }

        private void BotOnReceiveError(object sender, ReceiveErrorEventArgs e)
        {
            MessageBox.Show(e.ApiRequestException.Message, @"Telegram Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}