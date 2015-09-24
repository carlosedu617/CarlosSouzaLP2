using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public string Matricula { get; set; }
        abstract public double ValeAlimentacao { get; set; }
        abstract public double Aliquota { get; set; }
    }
}
