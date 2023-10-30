using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            dontShowPasswordImage.Visible = false;
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            txtbName.ForeColor = Color.White;
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            txtbPassword.ForeColor = Color.White;
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
            if (txtbName.Text == "Digite seu Usuário")
            {
                txtbName.Clear();
            }
        }

        private void txtbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbPassword.Text == "Digite a Senha")
            {
                txtbPassword.Clear();
                txtbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.White;
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
    }
}