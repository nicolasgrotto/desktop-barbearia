﻿using MySql.Data.MySqlClient;
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
            string conexao = "server=localhost;database=db_barbearia;uid=root;pwd=jhon";
            MySqlConnection conexaoMysql = new MySqlConnection(conexao);
            conexaoMysql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select tb_clientes.id_cliente,cortes,datahora from tb_agendamento inner join tb_clientes on tb_clientes.id_cliente=tb_agendamento.id_cliente where datahora > now()+1;", conexaoMysql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSchedules.DataSource = dt;
        }
    }
}