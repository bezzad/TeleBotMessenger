using System.Drawing;
using System.Windows.Forms;

namespace TeleBotMessenger.Helper
{
    public static class Screenshot
    {
        private static PictureBox _pbularBox = new PictureBox();

        public static Bitmap TakeSnapshot(this Control ctl)
        {
            var bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
            var g = Graphics.FromImage(bmp);
            g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
            return bmp;
        }

        public static void Blur(this Control ctl)
        {
            ctl.Controls.Add(_pbularBox);
            _pbularBox.Dock = DockStyle.Fill;

            var bmp = ctl.TakeSnapshot();
            bmp.GaussianBlur(4);

            _pbularBox.Image = bmp;
            _pbularBox.BringToFront();
        }

        public static void UnBlur(this Control ctl)
        {
            ctl.Controls.Remove(_pbularBox);
            _pbularBox.Image = null;
            _pbularBox.SendToBack();
        }
    }
}