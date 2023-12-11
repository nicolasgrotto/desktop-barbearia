﻿using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class ChangePasswordScreen : Form
    {
        public ChangePasswordScreen()
        {
            InitializeComponent();
        }

        private void AlterarSenhaScreen_Load(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                label1.ForeColor = ThemeController.LightThemeForeColor;
                label2.ForeColor = ThemeController.LightThemeForeColor;
                label3.ForeColor = ThemeController.LightThemeForeColor;

                txtbPassword.ForeColor = ThemeController.LightThemeForeColor;
                txtbPassword.BackColor = ThemeController.LightThemeBackColor;

                txtbConfirmPassword.ForeColor = ThemeController.LightThemeForeColor;
                txtbConfirmPassword.BackColor = ThemeController.LightThemeBackColor;

                txtbNewPassword.ForeColor = ThemeController.LightThemeForeColor;
                txtbNewPassword.BackColor = ThemeController.LightThemeBackColor;

                btnChangePassword.BackColor = ThemeController.LightThemeBtnBackColor;
                btnChangePassword.ForeColor = ThemeController.LightThemeForeColor;
            }
        }

        private void btnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                btnChangePassword.BackColor = ThemeController.LightThemeBtnBackColor;
                btnChangePassword.ForeColor = ThemeController.LightThemeForeColor;
            }
            else
            {
                btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(225, 177, 44);
                btnChangePassword.BackColor = ThemeController.DarkThemeBackColor;
                btnChangePassword.ForeColor = Color.FromName("ControlLightLight");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=db_barbearia;uid=root;pwd=etec");
            try
            {
                mysql.Open();

                this.Cursor = Cursors.WaitCursor;

                MySqlDataReader reader = null;

                string typedActualPassword = txtbPassword.Text;
                string confirmPassword = txtbConfirmPassword.Text;
                string newPassword = txtbNewPassword.Text;

                bool isPasswordValid = false;

                using (MySqlCommand command = new MySqlCommand("select senha_barbeiro from tb_barbeiro;", mysql))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string actualPassword = reader.GetString("senha_barbeiro");

                        if (typedActualPassword == actualPassword)
                        {
                            if (typedActualPassword == confirmPassword)
                            {
                                isPasswordValid = true;
                            }
                            else
                            {
                                ErrorMessageBox eMessageBox = new ErrorMessageBox("As senhas não coincidem!");
                                eMessageBox.ShowDialog();
                            }
                        }
                        else
                        {
                            ErrorMessageBox eMessageBox = new ErrorMessageBox("Senha atual incorreta!");
                            eMessageBox.ShowDialog();
                        }
                    }

                    reader.Close();

                    if (isPasswordValid)
                    {
                        using (MySqlCommand command2 = new MySqlCommand($"update tb_barbeiro set senha_barbeiro = '{newPassword}' where senha_barbeiro = '{typedActualPassword}';", mysql))
                        {
                            command2.ExecuteNonQuery();

                            DoneMessageBox dMessageBox = new DoneMessageBox("Senha alterada com sucesso!");
                            dMessageBox.ShowDialog();
                        }
                    }

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
            finally
            {
                if (mysql.State == System.Data.ConnectionState.Open)
                {
                    mysql.Close();
                }
                mysql.Dispose();
            }
        }
    }
}