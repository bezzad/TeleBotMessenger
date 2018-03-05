using System.Windows.Forms;

namespace TeleBotMessenger.Forms
{
    public partial class InlineEditFrom : Form
    {
        private static readonly InlineEditFrom Instance = new InlineEditFrom();
        public static InlineEditFrom GetInstance()
        {
            return Instance;
        } 

        public string Value { get; set; }

        public InlineEditFrom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Value = null;
            Close();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Value = txtVal.Value;
            Close();
        }
    }
}
