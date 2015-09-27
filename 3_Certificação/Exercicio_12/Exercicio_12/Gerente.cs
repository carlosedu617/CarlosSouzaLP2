using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    public class Gerente : Empregado
    {
        public Gerente()
        {
            Aliquota = 0.065;
        }

       public string Area { get; set; }
        public double ValorAd { get; set; }
        protected override double GetTotalSalario()
        {
            return base.GetTotalSalario() + ValorAd;
        }
    }
}


