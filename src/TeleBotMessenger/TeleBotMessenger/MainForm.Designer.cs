namespace TeleBotMessenger
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
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbConnect.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Controls.Add(this.txtBotToken);
            this.gbConnect.Controls.Add(this.label2);
            this.gbConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbConnect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbConnect.Location = new System.Drawing.Point(0, 0);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(689, 77);
            this.gbConnect.TabIndex = 5;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Location = new System.Drawing.Point(585, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 27);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBotToken
            // 
            this.txtBotToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBotToken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBotToken.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBotToken.Location = new System.Drawing.Point(107, 30);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Size = new System.Drawing.Size(472, 27);
            this.txtBotToken.TabIndex = 6;
            this.txtBotToken.Text = "487322303:AAE0VfVSlJwa1-APuEKLO4lvLs4hHPmTxko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bot Token:";
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnSend);
            this.gbTools.Controls.Add(this.label3);
            this.gbTools.Controls.Add(this.rtxtText);
            this.gbTools.Controls.Add(this.btnTest);
            this.gbTools.Controls.Add(this.txtChannelName);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTools.Enabled = false;
            this.gbTools.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTools.Location = new System.Drawing.Point(0, 77);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(689, 503);
            this.gbTools.TabIndex = 6;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channels or Groups:   @";
            // 
            // txtChannelName
            // 
            this.txtChannelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtChannelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtChannelName.Location = new System.Drawing.Point(187, 31);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(294, 27);
            this.txtChannelName.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Location = new System.Drawing.Point(487, 31);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(92, 27);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rtxtText
            // 
            this.rtxtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtText.Location = new System.Drawing.Point(27, 160);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(636, 220);
            this.rtxtText.TabIndex = 4;
            this.rtxtText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message:";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(585, 464);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 27);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(689, 580);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.gbConnect);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Bot Messenger";
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBotToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtText;
        private System.Windows.Forms.Button btnSend;
    }
}

