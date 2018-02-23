using System;
using System.Windows.Forms;
using TeleBotMessenger.Helper;
using Telegram.Bot.Types;

namespace TeleBotMessenger
{
    public partial class MainForm : Form
    {
        User BotUser { get; set; }

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
                    BotUser = await TelegramHelper.StartBot(txtBotToken.Text);
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
                var count = await TelegramHelper.BotManager.Bot.GetChatMembersCountAsync("@" + txtChannelName.Text);
                MessageBox.Show("Connected successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Telegram Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
