using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class ChangePasswordScreen : Form
    {
        private struct RgbLightColors
        {
            public static Color backColor = Color.FromArgb(255, 255, 255);
            public static Color textColor = Color.FromArgb(0, 0, 0);
            public static Color btnBackColor = Color.FromArgb(215, 215, 215);
        }

        public ChangePasswordScreen()
        {
            InitializeComponent();
        }

        private void AlterarSenhaScreen_Load(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                label1.ForeColor = RgbLightColors.textColor;
                label2.ForeColor = RgbLightColors.textColor;
                label3.ForeColor = RgbLightColors.textColor;

                txtbPassword.ForeColor = RgbLightColors.textColor;
                txtbPassword.BackColor = RgbLightColors.backColor;

                txtbConfirmPassword.ForeColor = RgbLightColors.textColor;
                txtbConfirmPassword.BackColor = RgbLightColors.backColor;

                txtbNewPassword.ForeColor = RgbLightColors.textColor;
                txtbNewPassword.BackColor = RgbLightColors.backColor;

                btnChangePassword.BackColor = RgbLightColors.btnBackColor;
                btnChangePassword.ForeColor = RgbLightColors.textColor;
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
                btnChangePassword.BackColor = RgbLightColors.btnBackColor;
                btnChangePassword.ForeColor = RgbLightColors.textColor;
            }
            else
            {
                btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(225, 177, 44);
                btnChangePassword.BackColor = Color.FromArgb(40, 40, 40);
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
                                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    reader.Close();

                    if (isPasswordValid)
                    {
                        using (MySqlCommand command2 = new MySqlCommand($"update tb_barbeiro set senha_barbeiro = '{newPassword}' where senha_barbeiro = '{typedActualPassword}';", mysql))
                        {
                            command2.ExecuteNonQuery();

                            MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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