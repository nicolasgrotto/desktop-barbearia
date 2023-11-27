using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interdisciplinar2.Models
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            _connectionString = "server=localhost;database=db_barbearia;uid=root;pwd=etec;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}