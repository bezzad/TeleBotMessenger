using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MaterialSkin;
using MaterialSkin.Controls;
using TeleBotMessenger.Helper;
using TeleBotMessenger.Model;
using TeleBotMessenger.Properties;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace TeleBotMessenger.Forms
{
    public sealed partial class MainForm : MaterialForm
    {
        private User BotUser { get; set; }
        private string ChannelName => txtChannelName.Text.StartsWith("@") ? txtChannelName.Text : @"@" + txtChannelName.Text;
        private Image MsgImage { get; set; }
        private Font EmojiFont { get; } = new Font(@"Segoe UI Symbol", 11f, FontStyle.Bold);
        private Font RichTextBoxFont { get; } = new Font(@"Time News Roman", 11f, FontStyle.Regular);

        public MainForm()
        {
            InitializeComponent();
            Text += @" " + AssemblyInfo.Version.ToString(3);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue800, Primary.Blue500, Accent.Pink200, TextShade.WHITE);

            rtxtText.Font = RichTextBoxFont;
        }

        public IReplyMarkup GetKeyboardButtons()
        {
            var result = new List<InlineKeyboardButton[]>();
            foreach (InlinePanel panel in layout.Controls)
            {
                var keys = new List<InlineKeyboardButton>();
                foreach (var button in panel.Buttons)
                {
                    if (button.Address == null)
                        throw new Exception($"The {button.Text} address is empty!");

                    keys.Add(new InlineKeyboardUrlButton(button.Text, button.Address));
                }

                result.Add(keys.ToArray());
            }

            return new InlineKeyboardMarkup(result.ToArray());
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
                    txtBotToken.Enabled = false;
                }
                else
                {
                    TelegramHelper.BotManager.Bot.StopReceiving();
                    BotUser = null;
                    txtBotToken.Text = TelegramHelper.BotManager.BotApiKey;
                    btnConnect.Text = @"Connect";
                    pnlTools.Enabled = false;
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

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            layout.Controls.Add(new InlinePanel(layout.Width - 20));
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Telegram.Bot.Types.Message msg;
                if (MsgImage != null)
                {
                    using (var stream = new MemoryStream(MsgImage.ToByte()))
                    {
                        msg = await TelegramHelper.BotManager.Bot.SendPhotoAsync(ChannelName,
                            new FileToSend(Guid.NewGuid().ToString(), stream), rtxtText.Text,
                            replyMarkup: GetKeyboardButtons());
                    }
                }
                else
                {
                    msg = await TelegramHelper.BotManager.Bot.SendTextMessageAsync(
                        ChannelName, rtxtText.Text, ParseMode.Html, replyMarkup: GetKeyboardButtons());
                }

                lstMessages.Items.Add(TelegramMessage.Factory(msg));
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

        private void picAbout_Click(object sender, EventArgs e)
        {

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

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await emojiLayout.Load();
        }
    }
}