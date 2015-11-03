using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0311
{
    class ContaBancaria
    {
        protected string Cliente { get; set;}
        protected string NumConta { get; set; }
        protected double Saldo { get; set; }
        protected virtual void Sacar(double n)
        {
           if(n <= Saldo || Saldo > 0)
           {
               Saldo -= n;
           }
           else
           {
               Console.WriteLine("Seu saldo se tornará negativo.");
           }
           
        }
        protected void Depositar(double n)
        {
            Saldo += n;
        }
        protected void Transferencia(double n, ContaBancaria conta)
        {
            if (n <= Saldo || Saldo > 0)
            {
                Saldo -= n;
                conta.Saldo += n;
            }
            else
            {
                Console.WriteLine("A transferência não pode ser efetuada.");
            }
        }
    }
}
