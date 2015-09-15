using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1509_1_
{
    class Gerente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public double Salario { get; set; }
        public string Matricula { get; set; }
        public string Area { get; set; }
        public double ValorAd { get; set; }

        public double SalarioTotal()
        {
            return Salario + ValorAd;
        }

    }
}
