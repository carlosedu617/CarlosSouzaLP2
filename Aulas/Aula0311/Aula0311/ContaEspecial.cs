using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0311
{
    class ContaEspecial:ContaBancaria
    {
        public double Limite { get; set; }
        public override void Sacar(double n )
        {
            if (n <= Saldo+Limite || Saldo+Limite > 0)
            {
                Saldo -= n;
                if (Saldo < 0 )
                {
                    Saldo = 0;
                }
            }
            else
            {
                Console.WriteLine("Seu limite não cobre a transação.");
            }
          public override void Transferencia()
        }
    }
}
