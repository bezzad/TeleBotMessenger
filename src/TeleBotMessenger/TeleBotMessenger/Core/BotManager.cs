using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputMessageContents;

namespace TeleBotMessenger.Core.Telegram
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

        private async void BotOnInlineQueryReceived(object sender, InlineQueryEventArgs e)
        {
//            try
//            {
//                if (string.IsNullOrEmpty(e.InlineQuery.Query)) return;

//                var searchResults = await e.InlineQuery.Query.GetBookHintsAsync();
//                //
//                // Get new book wrapper object from Taaghche GET book API
//                var bookResults = searchResults?.ToList().Take(20).ToList(); // max is 40, limit for time is 5sec

//                const int thumbW = 100;
//                const int thumbH = 150;
//                var results = new List<InlineQueryResult>();

//                if (bookResults?.Any() == true)
//                    foreach (var sBook in bookResults)
//                    {
//                        if (!int.TryParse(sBook.Data.Id, out int bookId))
//                            continue;

//                        var book = await bookId.GetBookAsync();
//                        if (book == null) continue;

//                        var bInfo = book.GetBookInfo();

//                        var downloadLink = book.IsRtl ? "دریافت از طاقچه" : "Download from Taaghche";
//                        var icon = book.Type.ToLower() == "text" ? Emoji.Books : Emoji.Headphone;
//                        var msgText =
//                            $"<a href='{book.CoverUri}'>{icon}</a> «{book.Title}» " + Environment.NewLine +
//                            (string.IsNullOrEmpty(book.OffText)
//                                ? Environment.NewLine
//                                : $"{Emoji.Bookmark} {book.OffText}" + Environment.NewLine) +
//                            $"<a href='{string.Format(Settings.Default.TaaghcheBookUrl, book.Id)}'>{Emoji.InboxTray} {downloadLink}</a>" +
//                            Environment.NewLine + bInfo + Environment.NewLine +
//                            $"{book.Description.SummeryCreator(400)}\n\r";


//                        results.Add(new InlineQueryResultArticle
//                        {
//                            Id = book.Id.ToString(),
//                            Title = icon + " " + book.Title,
//                            Description = bInfo,
//                            Url = string.Format(Settings.Default.TaaghcheBookUrl, book.Id),
//                            ThumbUrl = book.CoverUri + $"?w={thumbW}&h={thumbH}",
//                            ThumbHeight = thumbH,
//                            ThumbWidth = thumbW,
//                            InputMessageContent = new InputTextMessageContent
//                            {
//                                DisableWebPagePreview = false,
//                                MessageText = msgText,
//                                ParseMode = ParseMode.Html
//                            }
//                        });
//                    }

//#if DEBUG
//                await Bot.AnswerInlineQueryAsync(e.InlineQuery.Id, results.ToArray(), isPersonal: false, cacheTime: 60);
//                // for debug
//#else
//                await Bot.AnswerInlineQueryAsync(e.InlineQuery.Id, results.ToArray(), isPersonal: false, cacheTime: InlineQueryResultCacheTimeSec);
//#endif
//            }
//            catch (Exception exp)
//            {
//                Logger.Error(exp);
//                Debugger.Break();
//            }
        }

        private async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs e)
        {
//            try
//            {
//                var command = e.CallbackQuery.Data.ToLower();
//                var user = await Context.AuthenticateByTelegramUser(e.CallbackQuery.From);
//                StartTimeToAnswerCallBack(user);
//                await Bot.SendChatActionAsync(e.CallbackQuery.From.Id, ChatAction.Typing);
//#if SingleUser
//                if (user.UserId != TestUserId) return;
//#endif
//                if (user.IsAuthenticated)
//                {
//                    if (user.Data.RequestSemaphoreSlim.CurrentCount == 0) return;

//                    try
//                    {
//                        // sure the user requested once time, other requests rejected from robot
//                        await user.Data.RequestSemaphoreSlim.WaitAsync();

//                        user.Data.LastCallBackQuery = e.CallbackQuery;
//                        var prefixLen = command.IndexOf("_", StringComparison.Ordinal);
//                        if (prefixLen > 1)
//                        {
//                            var methodName = command.Substring(0, prefixLen);
//                            var method = GetType().GetMethod(PrefixKeys.InlineKeyMethod + methodName,
//                                BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Instance);
//                            if (method != null)
//                                await (Task)method.Invoke(this, new object[] { user });
//                        }
//                    }
//                    catch (ApiRequestException apiExp)
//                    {
//                        if (apiExp.Message == "Bad Request: message is not modified")
//                            await AnswerCallbackQueryAsync(user, Localization.YourRequestRegistered);
//                    }
//                    finally
//                    {
//                        user.Data.RequestSemaphoreSlim.Release();
//                    }
//                }
//                else
//                {
//                    await Bot.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id, Localization.InvalidRequest);
//                }
//            }
//            catch (Exception exp)
//            {
//                Logger.Error(exp);
//                Debugger.Break();
//            }
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
//            try
//            {
//                var command = e.Message.Text?.GetNetMessage();
//                var user = await Context.AuthenticateByTelegramUser(e.Message.From);
//                await Bot.SendChatActionAsync(e.Message.From.Id, ChatAction.Typing);
//#if SingleUser
//                if (user.UserId != TestUserId) return;
//#endif
//                if (e.Message.Chat.Type != ChatType.Private)
//                {
//                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, Localization.InvalidRequest);
//                    return;
//                }

//                if (user?.IsAuthenticated == true)
//                {
//                    if (user.Data.RequestSemaphoreSlim.CurrentCount == 0) return;

//                    try
//                    {
//                        // sure the user requested once time, other requests rejected from robot
//                        await user.Data.RequestSemaphoreSlim.WaitAsync();

//                        user.Data.LastMessage = e.Message;
//                        user.Data.WaitingMessageQuery = command;

//                        // this is reply message for newsletter feedback or ...
//                        if (e.Message.ReplyToMessage != null)
//                        {
//                            await OnMessageReplyReceived(user);
//                            return;
//                        }

//                        var indexOfNumberSign = command?.IndexOf("#", StringComparison.Ordinal);
//                        var methodName = indexOfNumberSign.HasValue && indexOfNumberSign.Value > 1
//                            ? command.Substring(0, indexOfNumberSign.Value).Trim()
//                            : command?.Trim();

//                        var method = typeof(BotManager).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
//                            .FirstOrDefault(m => m.Name.StartsWith(PrefixKeys.MessageMethod) &&
//                                                 Localization.ResourceManager.GetString(
//                                                     m.Name.Replace(PrefixKeys.MessageMethod, "")) == methodName);

//                        if (method != null)
//                            await (Task)method.Invoke(this, new object[] { user });
//                    }
//                    finally
//                    {
//                        user.Data.RequestSemaphoreSlim.Release();
//                    }
//                }
//                else
//                {
//                    if (command?.StartsWith("start") == true)
//                    {
//                        var token = command.Replace("start", "").Trim();
//                        if (!string.IsNullOrEmpty(token))
//                        {
//                            token = token.UrlDecrypt(Settings.Default.TelegramApiPass);
//                            var underlineIndex = token.IndexOf("_", StringComparison.Ordinal);
//                            var id = token.Substring(0, underlineIndex);
//                            var time = token.Substring(underlineIndex + 1);

//                            if (int.TryParse(id, out int userId) &&
//                                DateTime.TryParse(time, out DateTime startTime))
//                            {
//                                if ((DateTime.Now - startTime).TotalMinutes <
//                                    Settings.Default.TelegramRegisterLinkExpireTimeMinutes &&
//                                    await Context.AddTelegramIdAsync(userId, e.Message.From.Id))
//                                {
//                                    e.Message.Text = "start";
//                                    BotOnMessageReceived(sender, e);
//                                    return;
//                                }
//                                await Bot.SendTextMessageAsync(e.Message.Chat.Id,
//                                    Localization.RegisterationLinkHasBeenExpired);
//                            }
//                        }
//                    }
//                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, Localization.InvalidRequest);
//                }
//            }
//            catch (Exception exp)
//            {
//                Logger.Error(exp);
//                Debugger.Break();
//            }
        }

        private void BotOnReceiveError(object sender, ReceiveErrorEventArgs e)
        {
            MessageBox.Show(e.ApiRequestException.Message, "Telegram Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}