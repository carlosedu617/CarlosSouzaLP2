using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Aula2209
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "server=localhost; Database=test; Uid=root; Pwd=";

            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();

            Console.WriteLine("Registre uma nova pessoa.");
            string nome = Console.ReadLine();
            command.Connection = conn;
            command.CommandText = string.Format("insert into Pessoa (Nome) values ('{0}')", nome);

           

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Pessoa registrada.");
        }
    }
}