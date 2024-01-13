using MySql.Data.MySqlClient;

namespace interdisciplinar2.Models
{
    public class Login : DbConnection
    {
        public bool AuthenticateUser(string userName, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataReader reader = null;

                using (MySqlCommand command = new MySqlCommand($"SELECT nome_barbeiro, senha_barbeiro FROM tb_barbeiro WHERE nome_barbeiro = @NomeBarbeiro AND senha_barbeiro = @SenhaBarbeiro;", connection))
                {
                    command.Parameters.AddWithValue("@NomeBarbeiro", userName);
                    command.Parameters.AddWithValue("@SenhaBarbeiro", password);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string user = reader.GetString("nome_barbeiro");

                        string userPassword = reader.GetString("senha_barbeiro");

                        if (userName == user && password == userPassword)
                        {
                            return true;
                        }
                    }
                    reader.Close();
                }
            }
            return false;
        }
    }
}