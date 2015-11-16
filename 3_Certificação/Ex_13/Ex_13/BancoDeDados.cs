using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ex_13
{
    class BancoDeDados
    {
        MySqlConnection conn;
        private string conexao = "Server = localhost ; Database = novobd ; uid = root ; pwd = cadu";

        public BancoDeDados(string conexao = "")
        {
            if (string.IsNullOrEmpty(conexao))
            {
                conexao = this.conexao;
            }
            conn = new MySqlConnection(conexao);
        }

        public void InserirDado(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.ExecuteNonQuery();
            FecharConexao();
        }

        public MySqlDataReader PegarDados(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }

            return cmd.ExecuteReader();
        }

        public void FecharConexao()
        {
            conn.Close();
        }
    }
}
