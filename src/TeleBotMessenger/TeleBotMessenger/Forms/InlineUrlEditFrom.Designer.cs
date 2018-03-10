namespace TeleBotMessenger.Forms
{
    partial class InlineUrlEditFrom
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
            this.btnOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Depth = 0;
            this.btnOk.Location = new System.Drawing.Point(198, 85);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(70, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(122, 85);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.Color.White;
            this.txtText.Depth = 0;
            this.txtText.Hint = "Button Text";
            this.txtText.Location = new System.Drawing.Point(8, 16);
            this.txtText.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.Size = new System.Drawing.Size(262, 23);
            this.txtText.TabIndex = 7;
            this.txtText.UseSystemPasswordChar = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BackColor = System.Drawing.Color.White;
            this.txtUrl.Depth = 0;
            this.txtUrl.Hint = "Url Address";
            this.txtUrl.Location = new System.Drawing.Point(8, 45);
            this.txtUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.Size = new System.Drawing.Size(262, 23);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.UseSystemPasswordChar = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(284, 153);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.Color.White;
            this.tabPage.Controls.Add(this.txtText);
            this.tabPage.Controls.Add(this.txtUrl);
            this.tabPage.Controls.Add(this.btnOk);
            this.tabPage.Controls.Add(this.btnCancel);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(276, 127);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPageMain";
            // 
            // InlineUrlEditFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InlineUrlEditFrom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Inline Url Button";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtText;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUrl;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
    }
}