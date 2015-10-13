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
            ConectaBD bd = new ConectaBD();
            List<Pessoa> pessoas = new List<Pessoa>();

            Menu(); 

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Pessoa pessoinha = new Pessoa();
                pessoinha.Nome = Console.ReadLine();
                pessoinha.Sobrenome = Console.ReadLine();
                pessoinha.Peso = double.Parse(Console.ReadLine());
                pessoinha.Altura = double.Parse(Console.ReadLine());
                pessoinha.Telefone = Console.ReadLine();

                pessoas.Add(pessoinha);

                string q = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone)VALUES ('{0}','{1}','{2}','{3}','{4}')", pessoinha.Nome, pessoinha.Sobrenome, pessoinha.Peso, pessoinha.Altura, pessoinha.Telefone);

                bd.InserirDado(q);
            }

            else if(n == 2)
            {
                Console.WriteLine("1- Para consultar pelo nome.");
                Console.WriteLine("2- Para consultar pelo id.");
                int escolha = int.Parse(Console.ReadLine());

                if(escolha == 1)
                {
                    string q = string.Format("SELECT Nome FROM Pessoa ");
                    MySqlDataReader r = bd.SelecionarDados(q);


                }

                bd.SelecionarDado();

            }

            else
            {
                Menu();
            }
        }


        public static void Menu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1-Inserir dado");
            Console.WriteLine("2-Consultar");

        }
    }
}
