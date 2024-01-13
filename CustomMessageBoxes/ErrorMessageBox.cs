using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interdisciplinar2.CustomMessageBoxes
{
    public partial class ErrorMessageBox : Form
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

        public ErrorMessageBox(string errorMessage)
        {
            InitializeComponent();

            timer1.Enabled = true;

            lblMessage.Text = errorMessage;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void ErrorMessageBox_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void iconPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ErrorMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.FromArgb(225, 177, 44);
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.FromName("ControlLightLight");
        }
    }
}