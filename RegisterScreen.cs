using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class AgendamentosScreen : Form
    {
        public AgendamentosScreen()
        {
            InitializeComponent();
        }

        private void LoadDatabaseData()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=db_barbearia;uid=root;pwd=etec");
            try
            {
                connection.Open();

                string commandString = "SELECT id_cliente, nome FROM tb_clientes;";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT id_cliente, nome FROM tb_clientes WHERE nome LIKE @nome";
                }

                MySqlDataAdapter adapter = null;

                using (MySqlCommand command = new MySqlCommand(commandString, connection))
                {
                    if (txtbSearch.Text != "")
                    {
                        command.Parameters.AddWithValue("@nome", txtbSearch.Text + "%");
                    }
                    else
                    {
                        command.CommandText = "SELECT id_cliente, nome FROM tb_clientes;";
                    }

                    adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dados = new string[3] { txtId.Text, txtCorte.Text, txtData.Text };
                int cont = 0;

                foreach (string values in dados)
                {
                    if (values == "")
                    {
                        cont++;
                    }
                };
                if (cont >= 1)
                {
                    ErrorMessageBox eMessageBox = new ErrorMessageBox("Você deixou " + cont + " campo(s) em branco, preencha-o(s)!");
                    eMessageBox.ShowDialog();
                }
                else
                {
                    string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon;";
                    MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                    conexaoMysql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into tb_agendamento(id_cliente,cortes,datahora) values(" + txtId.Text + ",'" + txtCorte.Text + "','" + txtData.Text + "');", conexaoMysql);
                    comando.ExecuteNonQuery();

                    DoneMessageBox dMessageBox = new DoneMessageBox("Agendamento concluído, o horário está marcado!");
                    dMessageBox.Show();

                    txtId.Text = "";
                    txtCorte.Text = "";
                    txtData.Text = "";
                }
            }
            catch (Exception)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox("Algo deu errado, verifique se os dados estão corretos!");
                eMessageBox.ShowDialog();
            }
        }

        private void AgendamentosScreen_Load(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                ibSearch.BackColor = ThemeController.LightThemeBtnBackColor;
                ibSearch.IconColor = ThemeController.LightThemeForeColor;

                label1.ForeColor = ThemeController.LightThemeForeColor;
                label2.ForeColor = ThemeController.LightThemeForeColor;
                label3.ForeColor = ThemeController.LightThemeForeColor;
                label4.ForeColor = ThemeController.LightThemeForeColor;

                btnCadastrar.BackColor = ThemeController.LightThemeBtnBackColor;
                btnCadastrar.ForeColor = ThemeController.LightThemeForeColor;
            }

            LoadDatabaseData();
        }

        private void ibSearch_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDatabaseData();
        }

        private void ibSearch_MouseEnter(object sender, EventArgs e)
        {
            ibSearch.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void ibSearch_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                ibSearch.BackColor = ThemeController.LightThemeBtnBackColor;
                ibSearch.IconColor = ThemeController.LightThemeForeColor;
            }
            else
            {
                ibSearch.BackColor = ThemeController.DarkThemeBackColor;
                ibSearch.IconColor = Color.White;
            }
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeController.GetTheme() == "light")
            {
                btnCadastrar.BackColor = ThemeController.LightThemeBtnBackColor;
                btnCadastrar.ForeColor = ThemeController.LightThemeForeColor;
            }
            else
            {
                btnCadastrar.BackColor = ThemeController.DarkThemeBackColor;
            }
        }
    }
}