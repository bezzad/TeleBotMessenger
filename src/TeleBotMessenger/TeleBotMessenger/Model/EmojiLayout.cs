using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleBotMessenger.Helper;

namespace TeleBotMessenger.Model
{
    public sealed class EmojiLayout : FlowLayoutPanel
    {
        public event EventHandler OnEmojiClick = delegate { };

        public EmojiLayout()
        {
            AutoScroll = true;
            BackColor = Color.Transparent;
        }

        public async Task Load()
        {
            await Task.Run(() =>
            {
                if (Controls.Count == 0)
                {
                    foreach (var emoji in Emoji.EmojiBitmap)
                    {
                        var btnEmoji = new Button
                        {
                            BackColor = Color.White,
                            BackgroundImage = emoji.Value,
                            BackgroundImageLayout = ImageLayout.Center,
                            FlatStyle = FlatStyle.Standard,
                            Cursor = Cursors.Hand,
                            Name = @"_" + emoji.Key,
                            Size = new Size(32, 32)
                        };
                        btnEmoji.Click += (se, ev) => OnEmojiClick.Invoke(se, ev);

                        ThreadSafeAddControl(btnEmoji);
                    }
                }
            });
        }

        public void ThreadSafeAddControl(Control ctrl)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (InvokeRequired)
            {
                Invoke(new Action(delegate { ThreadSafeAddControl(ctrl); }));
            }
            else
            {
                Controls.Add(ctrl);
            }
        }
    }
}