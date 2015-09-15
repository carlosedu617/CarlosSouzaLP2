using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509_2_
{
    class Gerente: Empregado
    {
        public string Area { get; set; }
        public double ValorAd { get; set; }


        public double SalarioTotal()
        {
            return Salario + ValorAd;
        }
    }
}
