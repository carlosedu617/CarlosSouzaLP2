using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Empregado : Funcionario
    {
        public double Salario { get; set; }
        public override double ValeAlimentacao
        {
            get
            {
                if (Salario * (8 / 100) > 750)
                {
                    return 750;
                }
                return Salario * (8 / 100);
            }
            set { }
        }
        public override double Aliquota
        {
            get
            {
                return (Salario + ValeAlimentacao) * (8 / 100);
            }
            set
            { }
        }
       

    }
}
