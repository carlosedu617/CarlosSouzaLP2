using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViagemProject
{
    public class Carro
    {
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Vagas { get; set; }
        public int Lugares { get; set; }
         public int Passageiros { get { return Lugares - Vagas; } }


        public static int totalCarros = 0;

        public Carro()
        {
            totalCarros++;
            Id = totalCarros;

        }

        public bool AdicionarPassageiros(int passageiro)
        {
            if (Vagas - passageiro < 0)
            {
                return false;

            }
            else
            {
                Vagas -= passageiro;
                return true;
            }
        } 

    }
}
