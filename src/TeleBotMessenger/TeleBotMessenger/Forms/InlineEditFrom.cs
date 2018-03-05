using System;
using System.Windows.Forms;
using TeleBotMessenger.Model;

namespace TeleBotMessenger.Forms
{
    public partial class InlineEditFrom : Form
    {
        public InlineUrlButton Value { get; set; }


        private InlineEditFrom()
        {
            InitializeComponent();
        }

        public static InlineEditFrom GetInstance(InlineUrlButton value)
        {
            var instance = new InlineEditFrom { Value = value };

            if (value.Text != @"Button" && value.Address != null)
            {
                instance.txtValue.Value = value.Text;
                instance.txtAddress.Value = value.Address.ToString();
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
                Value.Text = txtValue.Value;
                Value.Address = new Uri(txtAddress.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Change In-line Button Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
