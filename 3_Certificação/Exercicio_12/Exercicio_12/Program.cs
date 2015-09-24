using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de TERCEIRIZADOS: ");
            int qtdTerceirizados = int.Parse(Console.ReadLine());
            List<Terceirizado> Terceirizados = new List<Terceirizado>();
            for (int i = 0; i < qtdTerceirizados; i++)
            {
                Terceirizado terceirizado = new Terceirizado();
                Console.Write("Nome: ");
                terceirizado.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                terceirizado.Cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                terceirizado.DataNasc = DateTime.Parse(Console.ReadLine());
                Console.Write("Matricula: ");
                terceirizado.Matricula = Console.ReadLine();
                Console.Write("CNPJ: ");
                terceirizado.Cnpj = Console.ReadLine();
                Terceirizados.Add(terceirizado);
            }
            Console.Write("Informe a quantidade de EMPREGADOS:");
            int qtdEmpregados = int.Parse(Console.ReadLine());
            List<Empregado> Empregados = new List<Empregado>();
            for (int i = 0; i < qtdEmpregados; i++)
            {
                Empregado empregado = new Empregado();
                Console.Write("Nome: ");
                empregado.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                empregado.Cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                empregado.DataNasc = DateTime.Parse(Console.ReadLine());
                Console.Write("Matricula: ");
                empregado.Matricula = Console.ReadLine();
                Console.Write("Salário: ");
                empregado.Salario = double.Parse(Console.ReadLine());
                Empregados.Add(empregado);
            }
            Console.Write("Informe a quantidade de GERENTES: ");
            int qtdGerentes = int.Parse(Console.ReadLine());
            List<Gerente> Gerentes = new List<Gerente>();
            for (int i = 0; i < qtdGerentes; i++)
            {
                Gerente gerente = new Gerente();
                Console.Write("Nome: ");
                gerente.Nome = Console.ReadLine();
                Console.Write("CPF: ");
                gerente.Cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                gerente.DataNasc = DateTime.Parse(Console.ReadLine());
                Console.Write("Matricula: ");
                gerente.Matricula = Console.ReadLine();
                Console.Write("Salário: ");
                gerente.Salario = double.Parse(Console.ReadLine());
                Console.Write("Área: ");
                gerente.Area = Console.ReadLine();
                Console.Write("Valor adicional pela área: ");
                gerente.ValorAd = double.Parse(Console.ReadLine());
                Gerentes.Add(gerente);
            }
            double salarioEmpregado = 0;
            double salarioGerente = 0;
            foreach (Empregado empregado in Empregados)
            {
                salarioEmpregado += empregado.Salario + empregado.ValeAlimentacao - empregado.Aliquota;
            }
            foreach  (Gerente gerente in Gerentes)
            {
                salarioGerente += gerente.SalarioTotal + gerente.ValeAlimentacao - gerente.Aliquota;
            }
            double salarioTotal = salarioEmpregado + salarioGerente;
            Console.WriteLine("A folha salarial da empresa é de {0} Reais", salarioTotal);



        }
    }
}
