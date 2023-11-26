using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using MessageBox = System.Windows.Forms.MessageBox;

namespace interdisciplinar2
{
    public partial class LoginScreen : Form
    {
        public struct RgbLightColors
        {
            public static Color backColor = Color.FromArgb(255, 255, 255);
            public static Color textColor = Color.FromArgb(0, 0, 0);
            public static Color btnBackColor = Color.FromArgb(215, 215, 215);
        }

        public struct RgbDarkColors
        {
            public static Color backColor = Color.FromArgb(40, 40, 40);
            public static Color textColor = Color.FromArgb(255, 255, 255);
            public static Color btnBackColor = Color.FromArgb(40, 40, 40);
        }

        public LoginScreen()
        {
            InitializeComponent();

            dontShowPasswordImage.Visible = false;
        }

        private void DefaultNameText()
        {
            if (txtbName.Text == "Digite seu Usuário")
            {
                txtbName.Clear();
            }
        }

        private void DefaultPasswordText()
        {
            if (txtbPassword.Text == "Digite a Senha")
            {
                txtbPassword.Clear();
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                txtbName.ForeColor = RgbLightColors.textColor;
            }
            else
            {
                txtbName.ForeColor = Color.White;
            }
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            if (showPasswordImage.Visible == true)
            {
                txtbPassword.UseSystemPasswordChar = true;
            }

            if (ThemeController.GetTheme() == "light")
            {
                txtbPassword.ForeColor = RgbLightColors.textColor;
            }
            else
            {
                txtbPassword.ForeColor = Color.White;
            }
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Transparent;
            lblClose.ForeColor = Color.Black;
        }

        private void lblClose_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtbName_MouseClick(object sender, MouseEventArgs e)
        {
            DefaultNameText();

            if (lblInvalidUser.Visible == true)
                lblInvalidUser.Visible = false;

            if (lblInvalidPassword.Visible == true)
                lblInvalidPassword.Visible = false;
        }

        private void txtbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            DefaultPasswordText();

            if (lblInvalidUser.Visible == true)
                lblInvalidUser.Visible = false;

            if (lblInvalidPassword.Visible == true)
                lblInvalidPassword.Visible = false;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                btnLogin.BackColor = RgbLightColors.btnBackColor;
                btnLogin.ForeColor = RgbLightColors.textColor;
            }
            else
            {
                btnLogin.BackColor = Color.Transparent;
                btnLogin.ForeColor = Color.White;
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(251, 197, 49);
            btnLogin.ForeColor = Color.Black;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
            lblClose.BackColor = Color.Red;
        }

        private void showPasswordImage_MouseClick(object sender, MouseEventArgs e)
        {
            txtbPassword.UseSystemPasswordChar = false;

            showPasswordImage.Visible = false;
            dontShowPasswordImage.Visible = true;
        }

        private void dontShowPasswordImage_MouseClick(object sender, MouseEventArgs e)
        {
            txtbPassword.UseSystemPasswordChar = true;

            dontShowPasswordImage.Visible = false;
            showPasswordImage.Visible = true;
        }

        private void SqlInjectionPrevention()
        {
            if (txtbName.Text.Contains("'"))
                txtbPassword.Text = txtbPassword.Text.Replace("'", "");

            if (txtbPassword.Text.Contains("'"))
                txtbPassword.Text = txtbPassword.Text.Replace("'", "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=db_barbearia;uid=root;pwd=njhon");
            try
            {
                this.Cursor = Cursors.WaitCursor;

                mysql.Open();

                MySqlDataReader reader = null;

                using (MySqlCommand command = new MySqlCommand("SELECT nome_barbeiro, senha_barbeiro FROM tb_barbeiro", mysql))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string user = reader.GetString("nome_barbeiro");

                        string password = reader.GetString("senha_barbeiro");

                        SqlInjectionPrevention();

                        if (txtbName.Text == user && txtbPassword.Text == password)
                        {
                            MessageBox.Show("Login efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            MainScreen mainScreen = new MainScreen();
                            mainScreen.Show();
                        }
                        else
                        {
                            if (txtbName.Text != user)
                            {
                                lblInvalidUser.Visible = true;
                                txtbName.Text = "";
                            }

                            if (txtbPassword.Text != password)
                            {
                                DefaultPasswordText();

                                lblInvalidPassword.Visible = true;
                                txtbPassword.Text = "";
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (mysql.State == ConnectionState.Open)
                {
                    mysql.Close();
                }
                mysql.Dispose();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ipbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ipbMinimize.BackColor = Color.FromArgb(160, 160, 160);
        }

        private void ipbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ipbMinimize.BackColor = Color.FromArgb(251, 197, 49);
        }

        private void ipbMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                this.BackColor = RgbLightColors.backColor;

                btnLogin.BackColor = RgbLightColors.btnBackColor;
                btnLogin.ForeColor = RgbLightColors.textColor;

                label1.ForeColor = RgbLightColors.textColor;
                label2.ForeColor = RgbLightColors.textColor;
                label3.ForeColor = RgbLightColors.textColor;

                panel1.BackColor = RgbLightColors.textColor;
                panel2.BackColor = RgbLightColors.textColor;

                txtbName.BackColor = RgbLightColors.backColor;
                txtbName.ForeColor = RgbLightColors.textColor;
                txtbPassword.BackColor = RgbLightColors.backColor;
                txtbPassword.ForeColor = RgbLightColors.textColor;

                pictureBox2.Image = Properties.Resources.dark_human_icon;
                pictureBox3.Image = Properties.Resources.dark_lock_solid;
                dontShowPasswordImage.Image = Properties.Resources.dark_dont_show_password_icon_removebg_preview;
                showPasswordImage.Image = Properties.Resources.dark_show_password_icon_removebg_preview;
            }
        }

    }
}