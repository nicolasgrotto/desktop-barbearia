using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using interdisciplinar2.Models;

namespace interdisciplinar2
{
    public partial class SplashScreen : Form
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

        public struct RgbLightColors
        {
            public static Color backColor = Color.FromArgb(255, 255, 255);
            public static Color textColor = Color.FromArgb(0, 0, 0);
        }

        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            progressBar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;

            progressBar.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Stop();

                this.Hide();

                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "Carregando...")
            {
                label1.Text = "Carregando";
            }
            else if (label1.Text == "Carregando")
            {
                label1.Text = "Carregando.";
            }
            else if (label1.Text == "Carregando.")
            {
                label1.Text = "Carregando..";
            }
            else if (label1.Text == "Carregando..")
            {
                label1.Text = "Carregando...";
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                this.BackColor = RgbLightColors.backColor;
                label1.ForeColor = RgbLightColors.textColor;

                progressBar.BackColor = RgbLightColors.backColor;
                progressBar.InnerColor = RgbLightColors.backColor;
                progressBar.ForeColor = RgbLightColors.textColor;
            }
        }
    }
}