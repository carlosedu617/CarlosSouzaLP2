using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    public class Empregado : Funcionario
    {
        public Empregado()
        {
            Aliquota = 0.08;
        }
        public double Salario { get; set; }
        public const double valorMaxAlimentacao = 750;
        protected double taxaConversao = 0.08;

        
        public double ValeAlimentacao
        {
            get
            {
                double valor = Salario*taxaConversao;
                if (valor > valorMaxAlimentacao)
                {
                    return valorMaxAlimentacao;
                }
                return valor;
            }
        }
        public double Aliquota { get; set; }

        public virtual double GerarPagamento()
        {
            var salarioTotal = GetTotalSalario();
            return salarioTotal - (salarioTotal*Aliquota);
        }

        protected virtual double GetTotalSalario()
        {
            return (Salario + ValeAlimentacao);
        }
    }
}
