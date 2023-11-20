﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

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
            if (showPasswordImage.Visible == true)
            {
                txtbPassword.UseSystemPasswordChar = true;
            }

            txtbPassword.ForeColor = Color.White;
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
    }
}