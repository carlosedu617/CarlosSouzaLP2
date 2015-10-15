using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula_1310
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoDeDados bd = new BancoDeDados();
            List<Pessoa> pessoas = new List<Pessoa>();

            Menu();
           

            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1 || escolha == 2 || escolha == 3)
            {
                if (escolha == 1)
                {
                    Pessoa pessoa = new Pessoa();
                    Console.WriteLine("Insira o NOME.");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Insira o SOBRENOME.");
                    pessoa.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Insira o PESO.");
                    pessoa.Peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a ALTURA.");
                    pessoa.Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o TELEFONE.");
                    pessoa.Telefone = Console.ReadLine();

                    pessoas.Add(pessoa);

                    string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone)VALUES ('{0}','{1}','{2}','{3}','{4}')", pessoa.Nome, pessoa.Sobrenome, pessoa.Peso, pessoa.Altura, pessoa.Telefone);

                    bd.InserirDado(q);
                }

                else if (escolha == 2)
                {
                    EscolherConsulta();
                    int busca = int.Parse(Console.ReadLine());
                    if (busca == 1)
                    {
                        Console.WriteLine("Digite o primeiro nome.");
                        string nome = Console.ReadLine();
                        string q = string.Format("SELECT Id,Nome,Sobrenome FROM Pessoa WHERE Nome = {0} ", escolha);
                        MySqlDataReader r = bd.SelecionarDados(q);
                        Console.WriteLine(r);
                        Console.WriteLine("Escreva o ID da pessoa que deseja.");
                        int id = int.Parse(Console.ReadLine());
                        string query = string.Format("Select * FROM Pessoa WHERE Id = {0}", id);
                        MySqlDataReader reader = bd.SelecionarDados(query);
                        Console.WriteLine(reader);

                    }
                    if (busca == 2)
                    {
                        Console.WriteLine("Escreva o ID da pessoa que deseja.");
                        int id = int.Parse(Console.ReadLine());
                        string query = string.Format("Select * FROM Pessoa WHERE Id = {0}", id);
                        MySqlDataReader reader = bd.SelecionarDados(query);
                        Console.WriteLine(reader);
                    }

                    else
                    {
                        Console.WriteLine("Digite um número válido.");
                        EscolherConsulta();
                    }



                }

                if (escolha == 3)
                {
                    bd.FecharConexao();
                }
                else
                {
                    Console.WriteLine("Digite um número válido.");
                }
            }

           
        }


        public static void Menu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1-Para inserir dado.");
            Console.WriteLine("2-Para consultar.");
            Console.WriteLine("3-Para fechar.");

        }
        public static void EscolherConsulta()
        {
            Console.WriteLine("1- Para consultar pelo nome.");
            Console.WriteLine("2- Para consultar pelo id.");
        }
       
    }
}
