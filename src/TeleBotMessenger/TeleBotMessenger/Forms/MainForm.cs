using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TeleBotMessenger.Helper;
using TeleBotMessenger.Model;
using TeleBotMessenger.Properties;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TeleBotMessenger.Forms
{
    public partial class MainForm : Form
    {
        private User BotUser { get; set; }
        private string ChannelName => "@" + txtChannelName.Value;
        private Image MsgImage { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }


        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (BotUser == null)
                {
                    BotUser = await TelegramHelper.StartBot(txtBotToken.Value);
                    Text = $"{AssemblyInfo.Title} (@{BotUser.Username})";
                    btnConnect.Text = "Stop";
                    gbTools.Enabled = true;
                    txtBotToken.Enabled = false;
                }
                else
                {
                    TelegramHelper.BotManager.Bot.StopReceiving();
                    BotUser = null;
                    Text = AssemblyInfo.Title;
                    btnConnect.Text = "Connect";
                    gbTools.Enabled = false;
                    txtBotToken.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Telegram Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var count = await TelegramHelper.BotManager.Bot.GetChatMembersCountAsync("@" + txtChannelName.Value);
                MessageBox.Show("Connected successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Telegram Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            new FileToSend(Guid.NewGuid().ToString(), stream), rtxtText.Text);
                    }
                }
                else
                {
                    msg = await TelegramHelper.BotManager.Bot.SendTextMessageAsync(ChannelName, rtxtText.Text, ParseMode.Html);
                }

                lstMessages.Items.Add(TelegramMessage.Factory(msg));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Telegram Send Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            rtxtText.SelectionColor = Color.DarkBlue;
            rtxtText.SelectedText = "<a href='http://taaghche.com'>Taaghche</a>";
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
            layout.Controls.Add(new InlinePanel());
        }
    }
}