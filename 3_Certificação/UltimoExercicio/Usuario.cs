using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UltimoExercicio
{
    class Usuario
    {
        

        public Usuario(MySqlDataReader reader)
        {
            ID = reader.GetInt32("ID");
            Nome = reader.GetString("Nome");
            Email = reader.GetString("Email");
            Login = reader.GetString("Login");
            Senha = reader.GetString("Senha");
            DataUltAcesso = reader.GetDateTime(5);
            
        }
        public int ID { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataUltAcesso { get; set; }

    }
}
