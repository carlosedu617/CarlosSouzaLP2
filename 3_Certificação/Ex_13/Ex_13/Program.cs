using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
             BancoDeDados bd = new BancoDeDados();

            while (true)
            {
                Menu();
                
                int escolha = int.Parse(Console.ReadLine());
                if (escolha != 1 && escolha != 2 && escolha != 3)
                {
                    MenuErro();
                    continue;
                }

                if (escolha == 1)
                {
                    Pessoa pessoa = new Pessoa();
                    Console.WriteLine("Insira o NOME:");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("insira o SOBRENOME:");
                    pessoa.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Insira o PESO:");
                    pessoa.Peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a Altura:");
                    pessoa.Altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o TELEFONE:");
                    pessoa.Telefone = Console.ReadLine();
                    string q = pessoa.GerarInsertQuery();
                    bd.InserirDado(q);
                }
                else if (escolha == 2)
                {
                    MenuConsulta();
                    int busca = int.Parse(Console.ReadLine());
                    string q = "";
                    if (busca == 1)
                    {
                        Console.WriteLine("Digite o NOME.");
                        string nome = Console.ReadLine();
                        q = Pessoa.GerarSelectQueryByName(nome);
                        if (reader.HasRows)
                        {
                            if(reader.ResultCount > 1)
                            {
                                Console.WriteLine("Digite o ID.");
                                int id = int.Parse(Console.ReadLine());
                                q = Pessoa.GerarSelectQueryByID(id);
                            }
                        }
                        
                    }
                    else if (busca == 2)
                    {
                        Console.WriteLine("Digite o ID.");
                        int id = int.Parse(Console.ReadLine());
                        q = Pessoa.GerarSelectQueryByID(id);
                    }
                    else
                    {
                        MenuErro();
                        continue;
                    }

                    List<Pessoa> pessoas = Pessoa.CriarPessoaPeloMySqlReader(bd.PegarDados(q));
                    foreach (var pessoa in pessoas)
                    {
                        PrintarPessoa(pessoa);
                    }
                }
               
            }
        }

        private static void PrintarPessoa(Pessoa pessoa)
        {
            Console.WriteLine("ID = '{0}' Nome = '{1}' Sobrenome = '{2}' Altura = '{3}' Peso = '{4}' Telefone = '{5}'",pessoa.Id , pessoa.Nome , pessoa.Sobrenome , pessoa.Altura , pessoa.Peso , pessoa.Telefone);
        }

        private static void MenuErro()
        {
            Console.WriteLine("Opção Inválida.");
        }

        public static void Menu()
        {
            Console.WriteLine("Escolha:");
            Console.WriteLine("  1-Para cadastrar uma pessoa.");
            Console.WriteLine("  2-Para buscar uma pessoa.");
            
        }

        public static void MenuConsulta()
        {
            Console.WriteLine("É possível realizar a consulta de 2 maneiras:");
            Console.WriteLine("   1-Para buscar pelo primeiro nome.");
            Console.WriteLine("   2-Para buscar pelo ID.");
        }
        
    }
}
