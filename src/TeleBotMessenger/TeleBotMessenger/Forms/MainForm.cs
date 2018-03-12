using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TeleBotMessenger.Helper;
using TeleBotMessenger.Model;
using TeleBotMessenger.Properties;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TeleBotMessenger.Forms
{
    public sealed partial class MainForm : MaterialForm
    {
        private Image _msgImage;
        private Image MsgImage
        {
            get => _msgImage;
            set
            {
                _msgImage = value;
                btnAddLink.Enabled = _msgImage == null;
                UpdateTextLength();
            }
        }

        private User BotUser { get; set; }
        private string ChannelName => txtChannelName.Text.StartsWith("@") ? txtChannelName.Text : @"@" + txtChannelName.Text;
        private Font EmojiFont { get; } = new Font(@"Segoe UI Symbol", 11f, FontStyle.Bold);
        private Font RichTextBoxFont { get; } = new Font(@"Time News Roman", 11f, FontStyle.Regular);
        private MaterialSkinManager MaterialSkinManager { get; } = MaterialSkinManager.Instance;
        private string StoragePath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AssemblyInfo.Product, @"sent_messages.json");
        private TelegramMessage EditedMessage { get; set; }

        public MainForm()
        {
            InitializeComponent();

            Text += @" " + AssemblyInfo.Version.ToString(3);
            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue800, Primary.Blue500,
                Accent.Pink200, TextShade.WHITE);

            rtxtText.Font = RichTextBoxFont;
            lstSentMessages.BackColor = lstSentMessages.Parent.BackColor;
            MsgImage = null;

            picNightMode.MouseHover += (s, e) =>
            {
                if (MaterialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
                    picNightMode.Image = Resources.dark_hover_moon;
            };

            picNightMode.MouseLeave += (s, e) =>
            {
                if (MaterialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
                    picNightMode.Image = Resources.dark_moon;
            };

            picNightMode.Click += (s, e) =>
            {
                if (MaterialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
                {
                    MaterialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    picNightMode.Image = Resources.dark_moon;
                }
                else
                {
                    MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    picNightMode.Image = Resources.light_moon;
                }

                lstSentMessages.BackColor = lstSentMessages.Parent.BackColor;
            };

            rtxtText.KeyUp += (s, e) => UpdateTextLength();
            btnAddRow.Click += (s, e) => AddRow();
        }

        private List<TelegramInlineUrlButton[]> GetKeyboardButtons()
        {
            var result = new List<TelegramInlineUrlButton[]>();
            foreach (InlinePanel panel in layout.Controls)
            {
                var keys = new List<TelegramInlineUrlButton>();
                foreach (var button in panel.Buttons)
                {
                    if (button.Address == null)
                        throw new Exception($"The {button.Text} address is empty!");

                    keys.Add(new TelegramInlineUrlButton(button.Text, button.Address));
                }

                result.Add(keys.ToArray());
            }

            return result;
        }
        private void SetKeyboardButtons(IEnumerable<TelegramInlineUrlButton[]> keyboard)
        {
            layout.Controls.Clear();

            foreach (var row in keyboard)
            {
                var rowPanel = AddRow();
                rowPanel.Buttons.Clear();
                foreach (var btn in row)
                {
                    rowPanel.Add(new InlineButton(this)
                    {
                        Text = btn.Text,
                        Address = new Uri(btn.Url)
                    });
                }
            }
        }
        private InlinePanel AddRow()
        {
            var panel = new InlinePanel(layout.Width - 20, this);
            layout.Controls.Add(panel);
            return panel;
        }

        private void UpdateTextLength()
        {
            var maxLen = 4096;
            if (EditedMessage?.Message?.Caption != null || MsgImage != null) // Photo Message
                maxLen = 200;

            var remain = maxLen - rtxtText.Text.Length;
            lblRemainChar.Text = remain.ToString();
            lblRemainChar.ForeColor = remain < 0 ? Color.Red : Color.Black;
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (BotUser == null)
                {
                    BotUser = await TelegramHelper.StartBot(txtBotToken.Text);
                    txtBotToken.Text = @"@" + BotUser.Username;
                    btnConnect.Text = @"Stop";
                    pnlTools.Enabled = true;
                    pnlTools.UnBlur();
                    txtBotToken.Enabled = false;
                }
                else
                {
                    TelegramHelper.BotManager.Bot.StopReceiving();
                    BotUser = null;
                    txtBotToken.Text = TelegramHelper.BotManager.BotApiKey;
                    btnConnect.Text = @"Connect";
                    pnlTools.Enabled = false;
                    pnlTools.Blur();
                    txtBotToken.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Telegram Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                await TelegramHelper.BotManager.Bot.GetChatMembersCountAsync(ChannelName);
                MessageBox.Show(@"Channel or group id is true!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Telegram Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            // don't use below code to RTL because change styles
            //rtxtText.RightToLeft = RightToLeft.No;

            int indexOfQr = rtxtText.Rtf.IndexOf(@"\qr", StringComparison.Ordinal);
            if (indexOfQr != -1)
                rtxtText.Rtf = rtxtText.Rtf.Remove(indexOfQr, @"\qr".Length);

            rtxtText.Focus();
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            // don't use below code to RTL because change styles
            //rtxtText.RightToLeft = RightToLeft.Yes;

            var indexofltrparObject = rtxtText.Rtf.IndexOf(@"\rtlpar", StringComparison.Ordinal);
            if (indexofltrparObject != -1 && rtxtText.Rtf.IndexOf(@"\rtlpar\qr", StringComparison.Ordinal) <= 0)
                rtxtText.Rtf = rtxtText.Rtf.Insert(indexofltrparObject, @"\qr");

            rtxtText.Focus();
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            if (emojiLayout.Visible)
                emojiLayout.Hide();
            else
                emojiLayout.Show();
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            rtxtText.SelectionColor = Color.DarkBlue;
            var selectedText = rtxtText.SelectedText;
            if (string.IsNullOrWhiteSpace(selectedText))
                selectedText = @"link_name";
            rtxtText.SelectedText = $"<a href='https://taaghche.ir/'>{selectedText}</a>";
            rtxtText.SelectionColor = rtxtText.ForeColor;

            rtxtText.Focus();
        }

        private void pix_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = Resources.PicBoxFilter,
                RestoreDirectory = true,
                Title = Resources.PixBoxTitle
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                pix.BackgroundImage = MsgImage = Image.FromFile(ofd.FileName);
            }
            else
            {
                pix.BackgroundImage = Resources.background;
                MsgImage = null;
            }
        }

        private async void picAbout_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var title = Text;
                this.ThreadSafeCall(() => progress.Show());

                this.ThreadSafeCall(() => Text = AssemblyInfo.Copyright);
                await Task.Delay(1000);

                this.ThreadSafeCall(() => Text = AssemblyInfo.Company);
                await Task.Delay(1000);

                this.ThreadSafeCall(() => Text = AssemblyInfo.Trademark);
                await Task.Delay(1000);

                this.ThreadSafeCall(() => Text = AssemblyInfo.Description);
                await Task.Delay(2000);

                this.ThreadSafeCall(() => Text = AssemblyInfo.Title);
                await Task.Delay(1000);

                this.ThreadSafeCall(() => Text = title);
                await Task.Delay(1000);

                this.ThreadSafeCall(() => progress.Hide());
            });
        }

        private void emojiLayout_OnEmojiClick(object sender, EventArgs e)
        {
            var emojiHex = ((Button)sender).Name.Trim('_');
            var ch = char.ConvertFromUtf32(Convert.ToInt32(emojiHex, 16));
            var start = rtxtText.SelectionStart;
            rtxtText.SelectedText = ch;
            rtxtText.Select(start, rtxtText.SelectionStart - start);
            rtxtText.SelectionFont = EmojiFont;
            rtxtText.SelectionColor = Color.FromArgb(24, 150, 147);
            rtxtText.Select(rtxtText.SelectionStart + rtxtText.SelectionLength, 0);
            rtxtText.SelectionFont = RichTextBoxFont;
            rtxtText.SelectionColor = DefaultForeColor;
            rtxtText.SelectedText = " ";
            rtxtText.Focus();
        }
        
        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            await Task.Delay(500);
            pnlTools.Blur();
            var lstMessages = await StringHelper.ReadAsync(StoragePath);
            lstSentMessages.Items.AddRange(lstMessages.ToArray());
            await emojiLayout.Load();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSend.Text = @"Send";
            rtxtText.Text = "";
            MsgImage = null;
            pix.BackgroundImage = Resources.background;
            EditedMessage = null;
            pix.Enabled = true;
            layout.Controls.Clear();
            tabControl.SelectTab(SendPage);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstSentMessages.SelectedItem is TelegramMessage selectedRow)
            {
                rtxtText.Rtf = selectedRow.Rtf;
                SetKeyboardButtons(selectedRow.Keyboard);

                if (selectedRow.Photo == null)
                {
                    pix.BackgroundImage = Resources.background;
                    MsgImage = null;
                }
                else // photo mode
                {
                    pix.BackgroundImage = MsgImage = selectedRow.Photo;
                }

                txtChannelName.Text = selectedRow.Message?.Chat?.Username;
                btnSend.Text = @"Update";
                pix.Enabled = false;
                EditedMessage = selectedRow;
                UpdateTextLength();
                SendPage.Show();
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var message = EditedMessage ?? new TelegramMessage();
                message.Rtf = rtxtText.Rtf;
                message.Keyboard = GetKeyboardButtons();

                if (message.Message?.Caption != null || MsgImage != null) // Photo Message
                {
                    message.Photo = MsgImage;
                    using (var stream = new MemoryStream(message.Photo.ToByte()))
                    {
                        if (EditedMessage != null) // Edit
                        {
                            message.Message = await TelegramHelper.BotManager.Bot.EditMessageCaptionAsync(ChannelName,
                                EditedMessage.Message.MessageId, rtxtText.Text,
                                new InlineKeyboardMarkup(message.Keyboard.ToArray()));
                        }
                        else //  New
                        {
                            message.Message = await TelegramHelper.BotManager.Bot.SendPhotoAsync(ChannelName,
                                new FileToSend(Guid.NewGuid().ToString(), stream), rtxtText.Text,
                                replyMarkup: new InlineKeyboardMarkup(message.Keyboard.ToArray()));

                            lstSentMessages.Items.Add(message);
                        }
                    }
                }
                else // Text Message
                {
                    if (EditedMessage != null) // Edit
                    {
                        message.Message = await TelegramHelper.BotManager.Bot.EditMessageTextAsync(
                            ChannelName, message.Message.MessageId, rtxtText.Text, ParseMode.Html,
                            replyMarkup: new InlineKeyboardMarkup(message.Keyboard.ToArray()));
                    }
                    else // New 
                    {
                        message.Message = await TelegramHelper.BotManager.Bot.SendTextMessageAsync(
                            ChannelName, rtxtText.Text, ParseMode.Html,
                            replyMarkup: new InlineKeyboardMarkup(message.Keyboard.ToArray()));

                        lstSentMessages.Items.Add(message);
                    }
                }

                await StringHelper.StoreAsync(StoragePath, lstSentMessages.Items.Cast<TelegramMessage>().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Telegram Send Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (lstSentMessages.SelectedItem is TelegramMessage selectedRow)
                {
                    await TelegramHelper.BotManager.Bot.DeleteMessageAsync(
                        selectedRow.Message.Chat.Id,
                        selectedRow.Message.MessageId);

                    lstSentMessages.Items.Remove(selectedRow);
                }
            }
            catch (ApiRequestException ax)
            {
                MessageBox.Show(ax.Message, @"Telegram Delete Message Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (lstSentMessages.SelectedItem is TelegramMessage selectedRow)
                {
                    lstSentMessages.Items.Remove(selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Telegram Delete Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await StringHelper.StoreAsync(StoragePath, lstSentMessages.Items.Cast<TelegramMessage>().ToList());
                Cursor = Cursors.Default;
            }
        }
    }
}