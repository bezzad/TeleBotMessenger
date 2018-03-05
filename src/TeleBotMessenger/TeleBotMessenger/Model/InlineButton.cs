using System;
using System.Windows.Forms;
using TeleBotMessenger.Forms;

namespace TeleBotMessenger.Model
{
    public sealed class InlineUrlButton : Button
    {
        public Uri Address { get; set; }

        public InlineUrlButton()
        {
            Cursor = Cursors.Hand;
            Text = @"Button";
            Click += OnEdit;
        }


        private void OnEdit(object sender, EventArgs e)
        {
            if (sender is InlineUrlButton btn)
            {
                var form = InlineEditFrom.GetInstance(btn);
                form.ShowDialog(this);
            }
        }
    }
}