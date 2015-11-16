using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UltimoExercicio
{
    class BancoDeDados
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost ; Database = utimoexercicio ; uid = root ; pwd = cadu");
        public MySqlDataReader PegarDados(string login , string pwd)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE Login=@login AND Senha=@pwd");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            return cmd.ExecuteReader();
        }
        public void UpdateData(Usuario usuario)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE usuario SET DataUltAcess =@data WHERE Login =@login", conn);
            cmd.Parameters.AddWithValue("@data", usuario.DataUltAcesso.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
