using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interdisciplinar2.CustomMessageBoxes
{
    public partial class DoneMessageBox : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public DoneMessageBox(string doneMessage)
        {
            InitializeComponent();

            lblMessage.Text = doneMessage;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void iconPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void DoneMessageBox_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DoneMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(225, 177, 44);
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = System.Drawing.Color.FromName("ControlLightLight");
        }
    }
}