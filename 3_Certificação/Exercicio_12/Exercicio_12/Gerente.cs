using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Gerente : Empregado
    {
        public string Area { get; set; }
        public double ValorAd { get; set; }
        public double SalarioTotal { get; set; }
        public override double ValeAlimentacao
        {
            get
            {
                if (SalarioTotal * (8 / 100) > 750)
                {
                    return 750;
                }
                return SalarioTotal * (8 / 100);
            }
            set
            { }
        }
        public override double Aliquota
        {
            get
            {
                return SalarioTotal * ((13 / 2) / 100);
            }

            set

            { }
        }
    }
}


