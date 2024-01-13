using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class HistoricScreen : Form
    {
        private ProgramTheme programTheme;

        public HistoricScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(tituloSelecionado);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;
            programTheme.LoadTheme();
        }

        private void HistoricScreen_Load(object sender, EventArgs e)
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

                MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora < now()-1 ORDER BY datahora DESC", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHistorico.DataSource = dt;

                DoneMessageBox dMessageBox = new DoneMessageBox("Histórico carregado com sucesso!");
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

                    MySqlDataAdapter adapter = new MySqlDataAdapter(" select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where WEEK (datahora) = WEEK( current_date ) - 1 AND YEAR( datahora) = YEAR( current_date ) ORDER BY datahora DESC;", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHistorico.DataSource = dt;
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

                    MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where month(datahora) = month(curdate() - interval 1 month) and year(datahora) = year(curdate() - interval 1 month) ORDER BY datahora DESC;", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHistorico.DataSource = dt;
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

                    MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora < current_date() ORDER BY datahora DESC; ", conexaoMysql);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHistorico.DataSource = dt;
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