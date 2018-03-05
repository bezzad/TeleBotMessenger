using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeleBotMessenger.Forms;
using TeleBotMessenger.Properties;

namespace TeleBotMessenger.Model
{
    public class InlinePanel : Panel
    {
        private readonly Button _addButton;
        private const int ButtonSpaces = 5;

        public List<Button> Buttons { get; set; } = new List<Button>();


        public InlinePanel()
        {
            Size = new Size(250, 38);
            // 
            // btnAddColumn
            // 
            _addButton = new Button
            {
                BackgroundImage = Resources.add_column,
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, 3),
                Size = new Size(44, 32),
                UseVisualStyleBackColor = true
            };
            _addButton.Click += OnAdd;
            _addButton.PerformClick();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            AddColumn();
            OrderColumns();
        }


        public void AddColumn()
        {
            // 
            // btnCol
            // 
            var btnCol = new Button
            {
                Cursor = Cursors.Hand,
                Text = "Button"
            };
            btnCol.Click += OnEdit;

            Buttons.Add(btnCol);
        }

        private void OnEdit(object sender, EventArgs e)
        {
            var form = InlineEditFrom.GetInstance();
            form.ShowDialog(this);
        }
        

        public void OrderColumns()
        {
            Controls.Clear();
            var initX = _addButton.Width + ButtonSpaces;
            Controls.Add(_addButton);
            var w = ((Size.Width - initX) / Buttons.Count) - ButtonSpaces;
            var h = Size.Height - 8;
            for (var i = 0; i < Buttons.Count; i++)
            {
                var button = Buttons[i];
                button.Size = new Size(w, h);
                button.Location = new Point(initX + (i * (ButtonSpaces + w)), 4);
                Controls.Add(button);
            }
        }
    }
}
