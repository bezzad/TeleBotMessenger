namespace TeleBotMessenger.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.txtBotToken = new Windows.Forms.HintTextBox(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.txtChannelName = new Windows.Forms.HintTextBox(this.components);
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.pix = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConnect.SuspendLayout();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.txtBotToken);
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbConnect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbConnect.Location = new System.Drawing.Point(0, 0);
            this.gbConnect.Margin = new System.Windows.Forms.Padding(2);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Padding = new System.Windows.Forms.Padding(2);
            this.gbConnect.Size = new System.Drawing.Size(476, 62);
            this.gbConnect.TabIndex = 5;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connection";
            // 
            // txtBotToken
            // 
            this.txtBotToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBotToken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtBotToken.EnterToTab = false;
            this.txtBotToken.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBotToken.HintColor = System.Drawing.Color.RoyalBlue;
            this.txtBotToken.HintValue = "Bot Token";
            this.txtBotToken.Location = new System.Drawing.Point(12, 23);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Size = new System.Drawing.Size(374, 23);
            this.txtBotToken.TabIndex = 8;
            this.txtBotToken.Text = "Bot Token";
            this.txtBotToken.TextForeColor = System.Drawing.Color.Black;
            this.txtBotToken.Value = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(391, 20);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 29);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnAlignRight);
            this.gbTools.Controls.Add(this.btnAlignLeft);
            this.gbTools.Controls.Add(this.txtChannelName);
            this.gbTools.Controls.Add(this.layout);
            this.gbTools.Controls.Add(this.btnAddRow);
            this.gbTools.Controls.Add(this.btnEdit);
            this.gbTools.Controls.Add(this.btnAddLink);
            this.gbTools.Controls.Add(this.lstMessages);
            this.gbTools.Controls.Add(this.pix);
            this.gbTools.Controls.Add(this.btnSend);
            this.gbTools.Controls.Add(this.rtxtText);
            this.gbTools.Controls.Add(this.btnTest);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTools.Enabled = false;
            this.gbTools.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTools.Location = new System.Drawing.Point(0, 62);
            this.gbTools.Margin = new System.Windows.Forms.Padding(2);
            this.gbTools.Name = "gbTools";
            this.gbTools.Padding = new System.Windows.Forms.Padding(2);
            this.gbTools.Size = new System.Drawing.Size(476, 596);
            this.gbTools.TabIndex = 6;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.BackgroundImage = global::TeleBotMessenger.Properties.Resources.align_right;
            this.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlignRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignRight.Location = new System.Drawing.Point(27, 300);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(30, 30);
            this.btnAlignRight.TabIndex = 17;
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.BackgroundImage = global::TeleBotMessenger.Properties.Resources.align_left;
            this.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlignLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignLeft.Location = new System.Drawing.Point(27, 271);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(30, 30);
            this.btnAlignLeft.TabIndex = 16;
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // txtChannelName
            // 
            this.txtChannelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtChannelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtChannelName.EnterToTab = false;
            this.txtChannelName.ForeColor = System.Drawing.Color.Gray;
            this.txtChannelName.HintColor = System.Drawing.Color.Gray;
            this.txtChannelName.HintValue = "Channel or Group";
            this.txtChannelName.Location = new System.Drawing.Point(36, 24);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(236, 23);
            this.txtChannelName.TabIndex = 15;
            this.txtChannelName.Text = "Channel or Group";
            this.txtChannelName.TextForeColor = System.Drawing.Color.Black;
            this.txtChannelName.Value = "";
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.layout.AutoScroll = true;
            this.layout.Location = new System.Drawing.Point(2, 430);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(279, 163);
            this.layout.TabIndex = 14;
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackgroundImage = global::TeleBotMessenger.Properties.Resources.add_row;
            this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Location = new System.Drawing.Point(27, 358);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(30, 30);
            this.btnAddRow.TabIndex = 12;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(337, 75);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 37);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackgroundImage = global::TeleBotMessenger.Properties.Resources.link_icon;
            this.btnAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.Location = new System.Drawing.Point(27, 329);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(30, 30);
            this.btnAddLink.TabIndex = 7;
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 15;
            this.lstMessages.Location = new System.Drawing.Point(337, 117);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(128, 259);
            this.lstMessages.TabIndex = 10;
            // 
            // pix
            // 
            this.pix.BackgroundImage = global::TeleBotMessenger.Properties.Resources.background;
            this.pix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pix.Location = new System.Drawing.Point(56, 75);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(195, 191);
            this.pix.TabIndex = 9;
            this.pix.TabStop = false;
            this.pix.Click += new System.EventHandler(this.pix_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(337, 548);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 37);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtText
            // 
            this.rtxtText.Location = new System.Drawing.Point(56, 271);
            this.rtxtText.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(195, 156);
            this.rtxtText.TabIndex = 4;
            this.rtxtText.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(277, 24);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(74, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "@";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(476, 658);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.gbConnect);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Bot Messenger";
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox rtxtText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.PictureBox pix;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private Windows.Forms.HintTextBox txtBotToken;
        private Windows.Forms.HintTextBox txtChannelName;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnAlignRight;
    }
}

