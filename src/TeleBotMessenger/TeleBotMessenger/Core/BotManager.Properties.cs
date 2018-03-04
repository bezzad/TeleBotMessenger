using Telegram.Bot;
using Telegram.Bot.Types;

namespace TeleBotMessenger.Core
{
    // BotManager Properties
    public partial class BotManager
    {
        private string PreLoggerMsg => "Telegram." + GetType().Name;
        public string BotApiKey { get; set; }
        public TelegramBotClient Bot { get; set; }
        public BotKeyboardCollection KeyboardCollection { get; set; }
        public User Me { get; set; }
        protected int MaxAnswerDurationMs { get; set; } = 12000; // - 2sec padding
        protected int InlineQueryResultCacheTimeSec { get; set; } = 7200; // 2hour
        protected int MaxPhotoMessageLength { get; set; } = 192;
        protected int MaxRowsPerPage { get; set; } = 10;

#if SingleUser
        private const int TestUserId = 302170; // my id
#endif

        #region Constructors

        public BotManager(string apiKey)
        {
            BotApiKey = apiKey;
            KeyboardCollection = new BotKeyboardCollection();
        }

        #endregion
    }
}