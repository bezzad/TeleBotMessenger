using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TeleBotMessenger.Model;

namespace TeleBotMessenger.Forms
{
    public partial class InlineUrlEditFrom : MaterialForm
    {
        public InlineButton Value { get; set; }


        private InlineUrlEditFrom()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
        }

        public static InlineUrlEditFrom GetInstance(InlineButton value)
        {
            var instance = new InlineUrlEditFrom { Value = value };

            if (value.Text != @"Button" && value.Address != null)
            {
                instance.txtText.Text = value.Text;
                instance.txtUrl.Text = value.Address.ToString();
            }

            return instance;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Text = txtText.Text;
                Value.Address = new Uri(txtUrl.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Change In-line Button Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
