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
    public partial class AgendamentosScreen : Form
    {
        public AgendamentosScreen()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtNome.Focus();
                }
                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Verefique se todos os campos estão preenchidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {

                    string conexao = "server= ;localhost= ; database= ; uid= ;pwd= ;";
                    MySqlConnection conexaoMsql = new MySqlConnection(conexao);
                    conexaoMsql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into tb_cliente values('" + txtNome.Text + "');", conexaoMsql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Agendamento feito", "Horário marcado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Text = "";
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Verifique isso" + ex.Message, "Algo deu errado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
