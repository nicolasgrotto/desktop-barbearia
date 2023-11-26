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
                string[] dados = new string[3] { txtNome.Text, txtCorte.Text,txtData.Text};
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
                    MessageBox.Show("Você deixou" + cont +  "campo em branco, o preencha!", "aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string conexao = "server=localhost;database=db_barbearia;uid=root;pwd= ;";
                    MySqlConnection conexaoMsql = new MySqlConnection(conexao);
                    conexaoMsql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into tb_cliente values('" + txtNome.Text + "','" + txtCorte.Text + "','" + txtData + "');", conexaoMsql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Agendamento feito", "Horário marcado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Verifique isso" + ex.Message, "Algo deu errado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult caixamensagem = MessageBox.Show("Deseja mesmo voltar a tela de menu", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (caixamensagem == DialogResult.Yes)
            {
                MainScreen mainscreen = new MainScreen();
                mainscreen.Show(); 
            }
        }

        private void AgendamentosScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
