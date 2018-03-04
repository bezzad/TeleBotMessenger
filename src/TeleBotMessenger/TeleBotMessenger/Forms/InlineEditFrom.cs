using System.ComponentModel;
using System.Windows.Forms;

namespace TeleBotMessenger.Forms
{
    public partial class InlineEditFrom : Form
    {
        private static readonly InlineEditFrom Instance = new InlineEditFrom();

        public static InlineEditFrom GetInstance(Button btn)
        {
            return Instance;
        } 

        public InlineEditFrom()
        {
            InitializeComponent();
        }
    }
}
