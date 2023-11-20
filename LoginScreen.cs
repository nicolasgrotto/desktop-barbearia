using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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

        private void SqlInjectionPrevention()
        {
            if (txtbName.Text.Contains("'"))
                txtbPassword.Text = txtbPassword.Text.Replace("'", "");

            if (txtbPassword.Text.Contains("'"))
                txtbPassword.Text = txtbPassword.Text.Replace("'", "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=db_barbearia;uid=root;pwd=nick1691");
            try
            {
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
    }
}