using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViagemProject
{
    class Program
    {
        static List<Carro>carros = new List<Carro>(); 
        static Carro PegarCarro(int idCarro)
        {
            foreach (Carro c in carros)
            {
                if (c.Id == idCarro)
                {
                    return c;
                }
                
            }
            return null;
        }
        static void Main(string[] args)
        {
            
            int qtdCarros = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdCarros; i++)
            {
                CriarCarro();
            }
           
            while (true)
            {
                int IdCarro = int.Parse(Console.ReadLine());
                if (IdCarro == -1)
                {
                    ExibirRelatorio();
                    break;
                }
                Carro carro = PegarCarro(IdCarro);
                if (carro == null)
                {
                    Console.WriteLine("Carro não encontrado");
                    continue;
                }
               
                  
                    if (carro.AdicionarPassageiros(1))
                    {
                          Console.WriteLine("Passageiro adicionado");
                    }
                    else
                    {
                        Console.WriteLine("Carro cheio");
                    }
            }
         


        }

        private static void CriarCarro()
        {

            Carro carro = new Carro();
            carros.Add(carro);
            carro.Modelo = Console.ReadLine();
            carro.Marca = Console.ReadLine();
            carro.Placa = Console.ReadLine();
            carro.Vagas = carro.Lugares = int.Parse(Console.ReadLine());
        }
        private static void ExibirRelatorio()
        {
            int totalPessoas = 0;
            for (int i = 0; i < carros.Count; i++)
            {   
                Carro carro = carros[i];
                totalPessoas += carro.Passageiros;
                Console.WriteLine("Carro " + carro.Id + ": " + carro.Modelo + " - " + carro.Marca + " ( " + carro.Placa + " )");
                Console.WriteLine("Passageiros: " +carro.Passageiros);

                if (carro.Vagas == 0)
                {
                    Console.WriteLine("Carro lotado");
                }
                else
                {
                    Console.WriteLine("Vagas restantes: " +carro.Vagas);
                }

            }
            Console.WriteLine("Total de pessoas na viagem: " +totalPessoas);

        
        }

    }
}
