using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_1310
{
    class BancoDeDados

    {
       
        MySqlConnection conn = new MySqlConnection("Server = localhost ; Database = test ; uid = root ; pwd = cadu");
        MySqlCommand cmd = new MySqlCommand();


        public void InserirDado(string query)
        {
            
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            
    
        }
        public MySqlDataReader SelecionarDados(string query)
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void FecharConexao()
        {
            conn.Close();
        }
        
    }
}
