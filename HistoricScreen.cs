using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interdisciplinar2
{
    public partial class HistoricScreen : Form
    {
        public HistoricScreen()
        {
            InitializeComponent();
        }

        private void HistoricScreen_Load(object sender, EventArgs e)
        {
            carregarBanco();
        }

        private void carregarBanco() 
        {
            string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon";
            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            conexaoMysql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente where datahora < now()-1", conexaoMysql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHistorico.DataSource = dt;
        }

        private void cbHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tituloSelecionado.Text = cbHistorico.Text;
            if(cbHistorico.SelectedIndex == 0)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(" select tb_clientes.id_cliente,cortes,datahora from tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente where WEEK (datahora) = WEEK( current_date ) - 1 AND YEAR( datahora) = YEAR( current_date );", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHistorico.DataSource = dt;
            }
            else if(cbHistorico.SelectedIndex == 1)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente where month(datahora) = month(curdate() - interval 1 month) and year(datahora) = year(curdate() - interval 1 month);", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHistorico.DataSource = dt;
            }
            else if(cbHistorico.SelectedIndex == 2)
            {
                string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("  select tb_clientes.id_cliente,cortes,datahora from tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente where datahora = ; ", conexaoMysql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHistorico.DataSource = dt;
            }
        }
    }
}
