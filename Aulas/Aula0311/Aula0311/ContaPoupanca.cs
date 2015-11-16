using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0311
{
    class ContaPoupanca:ContaBancaria
    {
        public string diaDeRendimento { get; set; }
        public void CalcularNovoSaldo(double taxa)
        {
            Saldo += Saldo * (taxa/100); 
        } 
    }
}
