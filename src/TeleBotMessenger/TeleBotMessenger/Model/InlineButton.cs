using System;
using System.Drawing;
using System.Windows.Forms;
using TeleBotMessenger.Forms;
using TeleBotMessenger.Helper;
using TeleBotMessenger.Properties;

namespace TeleBotMessenger.Model
{
    public sealed class InlineButton : Button
    {
        private readonly Control _parent;

        public Uri Address { get; set; }

        public InlineButton(Control parent)
        {
            _parent = parent;
            Cursor = Cursors.Hand;
            Text = @"Button";
            BackColor = Color.FromArgb(53, 58, 64);
            FlatStyle = FlatStyle.Popup;
            ForeColor = Color.FromArgb(252, 252, 252);
            Image = Resources.linking;
            ImageAlign = ContentAlignment.TopRight;
            Click += OnEdit;
        }


        private void OnEdit(object sender, EventArgs e)
        {
            if (sender is InlineButton btn)
            {
                var form = InlineUrlEditFrom.GetInstance(btn);
                _parent.Blur();
                form.ShowDialog(_parent);
                _parent.UnBlur();
            }
        }
    }
}