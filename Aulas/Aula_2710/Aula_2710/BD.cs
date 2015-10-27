using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Aula_2710
{
    class BD
    {
        MySqlConnection conn = new MySqlConnection("server='localhost',database=test,uid=root,pwd=");
        MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader SelectIsbn(string isbn)
        {
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            return null;
        }
        
        
    }
}
