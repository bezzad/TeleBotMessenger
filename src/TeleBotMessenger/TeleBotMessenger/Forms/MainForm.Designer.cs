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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pix = new System.Windows.Forms.PictureBox();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.SendPage = new System.Windows.Forms.TabPage();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.btnTest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtChannelName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBotToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EditPage = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SendPage.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.EditPage.SuspendLayout();
            this.tbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Depth = 0;
            this.btnConnect.Location = new System.Drawing.Point(293, 14);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = true;
            this.btnConnect.Size = new System.Drawing.Size(84, 29);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pix
            // 
            this.pix.BackgroundImage = global::TeleBotMessenger.Properties.Resources.background;
            this.pix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pix.Location = new System.Drawing.Point(54, 11);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(305, 190);
            this.pix.TabIndex = 9;
            this.pix.TabStop = false;
            this.pix.Click += new System.EventHandler(this.pix_Click);
            // 
            // tabSelector
            // 
            this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(0, 64);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(400, 44);
            this.tabSelector.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.SendPage);
            this.tabControl.Controls.Add(this.EditPage);
            this.tabControl.Controls.Add(this.tbAbout);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 110);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 644);
            this.tabControl.TabIndex = 8;
            // 
            // SendPage
            // 
            this.SendPage.BackColor = System.Drawing.Color.White;
            this.SendPage.Controls.Add(this.pnlTools);
            this.SendPage.Controls.Add(this.btnTest);
            this.SendPage.Controls.Add(this.txtChannelName);
            this.SendPage.Controls.Add(this.btnConnect);
            this.SendPage.Controls.Add(this.txtBotToken);
            this.SendPage.Location = new System.Drawing.Point(4, 21);
            this.SendPage.Name = "SendPage";
            this.SendPage.Padding = new System.Windows.Forms.Padding(3);
            this.SendPage.Size = new System.Drawing.Size(392, 619);
            this.SendPage.TabIndex = 0;
            this.SendPage.Text = "Send";
            // 
            // pnlTools
            // 
            this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTools.Controls.Add(this.btnSend);
            this.pnlTools.Controls.Add(this.btnAlignRight);
            this.pnlTools.Controls.Add(this.btnAlignLeft);
            this.pnlTools.Controls.Add(this.layout);
            this.pnlTools.Controls.Add(this.btnAddRow);
            this.pnlTools.Controls.Add(this.btnAddLink);
            this.pnlTools.Controls.Add(this.rtxtText);
            this.pnlTools.Controls.Add(this.pix);
            this.pnlTools.Enabled = false;
            this.pnlTools.Location = new System.Drawing.Point(3, 90);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(386, 526);
            this.pnlTools.TabIndex = 28;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Depth = 0;
            this.btnSend.Location = new System.Drawing.Point(5, 491);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(376, 29);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.BackgroundImage = global::TeleBotMessenger.Properties.Resources.align_right;
            this.btnAlignRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlignRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignRight.Location = new System.Drawing.Point(17, 237);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(30, 30);
            this.btnAlignRight.TabIndex = 34;
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.BackgroundImage = global::TeleBotMessenger.Properties.Resources.align_left;
            this.btnAlignLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlignLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlignLeft.Location = new System.Drawing.Point(17, 208);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(30, 30);
            this.btnAlignLeft.TabIndex = 33;
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.layout.AutoScroll = true;
            this.layout.Location = new System.Drawing.Point(3, 366);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(380, 119);
            this.layout.TabIndex = 32;
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackgroundImage = global::TeleBotMessenger.Properties.Resources.add_row;
            this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Location = new System.Drawing.Point(17, 295);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(30, 30);
            this.btnAddRow.TabIndex = 31;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackgroundImage = global::TeleBotMessenger.Properties.Resources.link_icon;
            this.btnAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.Location = new System.Drawing.Point(17, 266);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(30, 30);
            this.btnAddLink.TabIndex = 30;
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // rtxtText
            // 
            this.rtxtText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtText.Location = new System.Drawing.Point(54, 207);
            this.rtxtText.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(305, 156);
            this.rtxtText.TabIndex = 28;
            this.rtxtText.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Depth = 0;
            this.btnTest.Location = new System.Drawing.Point(293, 55);
            this.btnTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTest.Name = "btnTest";
            this.btnTest.Primary = true;
            this.btnTest.Size = new System.Drawing.Size(84, 29);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtChannelName
            // 
            this.txtChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannelName.Depth = 0;
            this.txtChannelName.Hint = "@Channel or @Group";
            this.txtChannelName.Location = new System.Drawing.Point(12, 55);
            this.txtChannelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtChannelName.PasswordChar = '\0';
            this.txtChannelName.SelectedText = "";
            this.txtChannelName.SelectionLength = 0;
            this.txtChannelName.SelectionStart = 0;
            this.txtChannelName.Size = new System.Drawing.Size(270, 23);
            this.txtChannelName.TabIndex = 19;
            this.txtChannelName.UseSystemPasswordChar = false;
            // 
            // txtBotToken
            // 
            this.txtBotToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBotToken.Depth = 0;
            this.txtBotToken.Hint = "Bot Token";
            this.txtBotToken.Location = new System.Drawing.Point(12, 14);
            this.txtBotToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBotToken.PasswordChar = '\0';
            this.txtBotToken.SelectedText = "";
            this.txtBotToken.SelectionLength = 0;
            this.txtBotToken.SelectionStart = 0;
            this.txtBotToken.Size = new System.Drawing.Size(270, 23);
            this.txtBotToken.TabIndex = 7;
            this.txtBotToken.UseSystemPasswordChar = false;
            // 
            // EditPage
            // 
            this.EditPage.Controls.Add(this.btnEdit);
            this.EditPage.Controls.Add(this.lstMessages);
            this.EditPage.Location = new System.Drawing.Point(4, 21);
            this.EditPage.Name = "EditPage";
            this.EditPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditPage.Size = new System.Drawing.Size(392, 619);
            this.EditPage.TabIndex = 1;
            this.EditPage.Text = "Edit";
            this.EditPage.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(170, 155);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 37);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 12;
            this.lstMessages.Location = new System.Drawing.Point(170, 197);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(128, 148);
            this.lstMessages.TabIndex = 12;
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.pictureBox1);
            this.tbAbout.Location = new System.Drawing.Point(4, 21);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tbAbout.Size = new System.Drawing.Size(392, 619);
            this.tbAbout.TabIndex = 2;
            this.tbAbout.Text = "About";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeleBotMessenger.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TeleBotMessenger.Properties.Resources.icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(400, 753);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tabSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(290, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Bot Messenger";
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.SendPage.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.EditPage.ResumeLayout(false);
            this.tbAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pix;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage SendPage;
        private System.Windows.Forms.TabPage EditPage;
        private System.Windows.Forms.Button btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBotToken;
        private MaterialSkin.Controls.MaterialRaisedButton btnTest;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtChannelName;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.RichTextBox rtxtText;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private System.Windows.Forms.TabPage tbAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

