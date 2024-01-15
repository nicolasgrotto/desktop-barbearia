using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar2.Models
{
    public class Schedule : DbConnection
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public void GetPastSchedulesByDate(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataAdapter adapter = null;

                DataTable dataTable = new DataTable();

                using (MySqlCommand command = new MySqlCommand("SELECT nome, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente WHERE datahora BETWEEN @startDate AND @endDate ORDER BY datahora DESC", connection))
                {
                    command.Parameters.AddWithValue("@startDate", StartDate);
                    command.Parameters.AddWithValue("@endDate", EndDate);

                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
        }

        public void GetFutureSchedulesByDate(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataAdapter adapter = null;

                DataTable dataTable = new DataTable();

                using (MySqlCommand command = new MySqlCommand("SELECT nome, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente WHERE datahora BETWEEN @startDate AND @endDate ORDER BY datahora ASC", connection))
                {
                    command.Parameters.AddWithValue("@startDate", StartDate);
                    command.Parameters.AddWithValue("@endDate", EndDate);

                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
        }

        public void GetAllPastSchedules(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataAdapter adapter = null;

                DataTable dataTable = new DataTable();

                using (MySqlCommand command = new MySqlCommand("SELECT nome, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente WHERE datahora < now()-1 ORDER BY datahora DESC;", connection))
                {
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
        }

        public void GetAllFutureSchedules(DataGridView dgv)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataAdapter adapter = null;

                DataTable dataTable = new DataTable();

                using (MySqlCommand command = new MySqlCommand("SELECT nome, cortes, datahora FROM tb_agendamentos INNER JOIN tb_clientes on tb_clientes.id_cliente=tb_agendamentos.id_cliente WHERE datahora > now()-1 ORDER BY datahora ASC;", connection))
                {
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
        }
    }
}