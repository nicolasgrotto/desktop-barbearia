using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class SchedulesScreen : Form
    {
        private ProgramTheme programTheme;
        public SchedulesScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(tituloSelecionado);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;
            programTheme.LoadTheme();
        }

        private void SchedulesScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadData();
        }

        private void LoadData()
        {
            string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            try
            {
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora > now() ORDER BY datahora ASC;", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;

                DoneMessageBox dMessageBox = new DoneMessageBox("Agendamentos carregados com sucesso!");
                dMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
            finally
            {
                if (conexaoMysql.State == ConnectionState.Open)
                {
                    conexaoMysql.Close();
                }
                conexaoMysql.Dispose();
            }
        }

        private void cbHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tituloSelecionado.Text = cbHistorico.Text;
            if (cbHistorico.SelectedIndex == 0)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                try
                {
                    conexaoMysql.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tb_clientes.id_cliente, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes ON tb_clientes.id_cliente = tb_agendamentos.id_cliente WHERE WEEK(datahora) = WEEK(DATE_ADD(CURDATE(), INTERVAL 1 WEEK)) AND YEAR(datahora) = YEAR(DATE_ADD(CURDATE(), INTERVAL 1 WEEK)) ORDER BY datahora ASC;", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSchedules.DataSource = dt;
                }
                catch (Exception ex)
                {
                    ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                    eMessageBox.ShowDialog();
                }
                finally
                {
                    if (conexaoMysql.State == ConnectionState.Open)
                    {
                        conexaoMysql.Close();
                    }
                    conexaoMysql.Dispose();
                }
            }
            else if (cbHistorico.SelectedIndex == 1)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                try
                {
                    conexaoMysql.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tb_clientes.id_cliente, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes ON tb_clientes.id_cliente = tb_agendamentos.id_cliente WHERE MONTH(datahora) = MONTH(DATE_ADD(CURDATE(), INTERVAL 1 MONTH)) AND YEAR(datahora) = YEAR(DATE_ADD(CURDATE(), INTERVAL 1 MONTH)) ORDER BY datahora ASC;", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSchedules.DataSource = dt;
                }
                catch (Exception ex)
                {
                    ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                    eMessageBox.ShowDialog();
                }
                finally
                {
                    if (conexaoMysql.State == ConnectionState.Open)
                    {
                        conexaoMysql.Close();
                    }
                    conexaoMysql.Dispose();
                }
            }
            else if (cbHistorico.SelectedIndex == 2)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                try
                {
                    conexaoMysql.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora > NOW() ORDER BY datahora ASC;", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSchedules.DataSource = dt;
                }
                catch (Exception ex)
                {
                    ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                    eMessageBox.ShowDialog();
                }
                finally
                {
                    if (conexaoMysql.State == ConnectionState.Open)
                    {
                        conexaoMysql.Close();
                    }
                    conexaoMysql.Dispose();
                }
            }
        }
    }
}