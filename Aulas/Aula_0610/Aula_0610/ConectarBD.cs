using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Aula_0610
{
   class ConectarBD
    {
        public void InserirRegistro(string query)
        {
           
            MySqlConnection conn = new MySqlConnection("Server = localhost ; Database = test ; uid = root ; pwd = ");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
