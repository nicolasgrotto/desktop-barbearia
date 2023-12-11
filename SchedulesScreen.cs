using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using Syncfusion.Windows.Forms.Tools;
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
    public partial class SchedulesScreen : Form
    {
        public SchedulesScreen()
        {
            InitializeComponent();
        }

        private void SchedulesScreen_Load(object sender, EventArgs e)
        {
            carregarBanco();

            if (ThemeController.GetTheme() == "light")
            {
                this.BackColor = ThemeController.LightThemeBackColor;
                tituloSelecionado.ForeColor = ThemeController.LightThemeForeColor;
            }
        }

        private void carregarBanco()
        {
            string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            conexaoMysql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora > now() ORDER BY datahora ASC;", conexaoMysql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSchedules.DataSource = dt;
        }

        private void cbHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tituloSelecionado.Text = cbHistorico.Text;
            if (cbHistorico.SelectedIndex == 0)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tb_clientes.id_cliente, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes ON tb_clientes.id_cliente = tb_agendamentos.id_cliente WHERE WEEK(datahora) = WEEK(DATE_ADD(CURDATE(), INTERVAL 1 WEEK)) AND YEAR(datahora) = YEAR(DATE_ADD(CURDATE(), INTERVAL 1 WEEK)) ORDER BY datahora ASC;", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
            else if (cbHistorico.SelectedIndex == 1)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tb_clientes.id_cliente, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes ON tb_clientes.id_cliente = tb_agendamentos.id_cliente WHERE MONTH(datahora) = MONTH(DATE_ADD(CURDATE(), INTERVAL 1 MONTH)) AND YEAR(datahora) = YEAR(DATE_ADD(CURDATE(), INTERVAL 1 MONTH)) ORDER BY datahora ASC;", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
            else if (cbHistorico.SelectedIndex == 2)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora > NOW() ORDER BY datahora ASC;", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
        }
    }
}