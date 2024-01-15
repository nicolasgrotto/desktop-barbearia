using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class LoginScreen : Form
    {
        private readonly Login login;
        private ProgramTheme programTheme;

        public LoginScreen()
        {
            InitializeComponent();

            dontShowPasswordImage.Visible = false;

            login = new Login();

            List<Label> labels = new List<Label>();
            {
                labels.Add(label1);
                labels.Add(label2);
                labels.Add(label3);
            }

            List<Button> buttons = new List<Button>();
            buttons.Add(btnLogin);

            List<TextBox> txtBoxes = new List<TextBox>();
            txtBoxes.Add(txtbName);
            txtBoxes.Add(txtbPassword);

            programTheme = new ProgramTheme();
            {
                programTheme.form = this;
                programTheme.labels = labels;
                programTheme.buttons = buttons;
                programTheme.txtBoxes = txtBoxes;
            }
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

                dontShowPasswordImage.Visible = false;
                showPasswordImage.Visible = true;
            }
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                txtbName.ForeColor = ProgramTheme.LightThemeForeColor;
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

            if (ProgramTheme.GetTheme() == "light")
            {
                txtbPassword.ForeColor = ProgramTheme.LightThemeForeColor;
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
            Application.Exit();
        }

        private void txtbName_MouseClick(object sender, MouseEventArgs e)
        {
            DefaultNameText();
        }

        private void txtbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            DefaultPasswordText();
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                btnLogin.BackColor = ProgramTheme.LightThemeBtnBackColor;
                btnLogin.ForeColor = ProgramTheme.LightThemeForeColor;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                bool isAuthenticate = login.AuthenticateUser(txtbName.Text, txtbPassword.Text);

                switch (isAuthenticate)
                {
                    case true:
                        DoneMessageBox dMessageBox = new DoneMessageBox("Login efetuado com sucesso!");
                        dMessageBox.ShowDialog();

                        this.Hide();
                        MainScreen mainScreen = new MainScreen();
                        mainScreen.Show();
                        break;

                    case false:
                        txtbName.Text = "Digite seu Usuário";
                        txtbName.ForeColor = Color.Gray;

                        txtbPassword.Text = "Digite a Senha";
                        txtbPassword.ForeColor = Color.Gray;
                        txtbPassword.UseSystemPasswordChar = false;

                        throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox("Usuário ou senha inválidos!");
                eMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }

            this.Cursor = Cursors.Default;
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
            programTheme.LoadTheme();

            if (ProgramTheme.GetTheme() == "light")
            {
                panel1.BackColor = ProgramTheme.LightThemeForeColor;
                panel2.BackColor = ProgramTheme.LightThemeForeColor;

                pictureBox2.Image = Properties.Resources.dark_human_icon;
                pictureBox3.Image = Properties.Resources.dark_lock_solid;
                dontShowPasswordImage.Image = Properties.Resources.dark_dont_show_password_icon_removebg_preview;
                showPasswordImage.Image = Properties.Resources.dark_show_password_icon_removebg_preview;
            }
            else
            {
                panel1.BackColor = ProgramTheme.DarkThemeForeColor;
                panel2.BackColor = ProgramTheme.DarkThemeForeColor;
            }
        }
    }
}