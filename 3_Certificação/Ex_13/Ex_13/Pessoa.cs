using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Telefone { get; set; }

        public string GerarInsertQuery()
        {
            return string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone)VALUES ('{0}','{1}','{2}','{3}','{4}')", Nome, Sobrenome, Peso, Altura, Telefone);
        }

        public static string GerarSelectQueryByName(string nome)
        {
            return string.Format(new CultureInfo("en"), "SELECT ID,Nome,Sobrenome FROM Pessoa WHERE Nome ='{0}'", nome);
        }

        public static string GerarSelectQueryByID(int id)
        {
            return string.Format(new CultureInfo("en"), "SELECT * FROM Pessoa WHERE ID ='{0}'", id);
        }

        public static List<Pessoa> CriarPessoaPeloMySqlReader(MySqlDataReader reader)
        {
            List<Pessoa> pessoas = new List<Pessoa>();


            while (reader.Read())
            {
                pessoas.Add(CriarPessoa(reader));
            }
            reader.Close();
            return pessoas;
        }

        public static Pessoa CriarPessoa(MySqlDataReader reader
            )
        {
            Pessoa p = new Pessoa();
            p.Id = reader.GetInt32("ID");
            p.Nome = reader.GetString("Nome");
            p.Sobrenome = reader.GetString("Sobrenome");
            p.Altura = reader.GetDouble("Altura");
            p.Peso = reader.GetDouble("Peso");
            p.Telefone = reader.GetString("Telefone");
            return p;
        }
    }
}
