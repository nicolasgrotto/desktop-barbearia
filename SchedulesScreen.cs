using MySql.Data.MySqlClient;
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
        }

        private void carregarBanco()
        {
            string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            conexaoMysql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora > now()+1;", conexaoMysql);
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

                MySqlDataAdapter adapter = new MySqlDataAdapter(" select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where week (datahora) = week( current_date ) - 1 and year( datahora) = ( current_date );", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
            else if (cbHistorico.SelectedIndex == 1)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora\r\nfrom tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente \r\nwhere month(datahora) = month(curdate() - interval 1 month)\r\nand year(datahora) = year(curdate() - interval 1 month);\r\n", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
            else if (cbHistorico.SelectedIndex == 2)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=etec";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("  select tb_clientes.id_cliente,cortes,datahora from tb_agendamentos inner join tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente where datahora = current_date(); ", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSchedules.DataSource = dt;
            }
        }
    }
}