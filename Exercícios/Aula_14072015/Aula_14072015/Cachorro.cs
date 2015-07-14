using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14072015
{
    class Cachorro
    {
        private string _nome;
        private int _tamanhoCm;
        private double _pesoKg;


        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public void SetTamanhoCm(int tamanhoCm)
        {
            _tamanhoCm = tamanhoCm;
        }
        public void SetPeso(double peso)
        {
            _pesoKg = peso;

        }

        public string GetNome()
        {
            return _nome;
        }
        public double GetPeso()
        {
            return _pesoKg;
        }

        public double GetTamanhoM()
        {
            return  _tamanhoCm / 100.0;
        }

        public double RacaoDiariaKg()
        {
            double tamM = _tamanhoCm / 100.0;

            return (_pesoKg / (tamM * tamM)) / 10.0;
        }
    }
}
