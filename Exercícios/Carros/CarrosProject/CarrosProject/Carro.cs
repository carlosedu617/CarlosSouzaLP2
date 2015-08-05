using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosProject
{
    public class Carro
    {
        private string modelo;
        private string placa;
        private string marca;
        private int ano;
        private double quilometragem;
        private double capacidadeTanque;
        private double potencia;


        public string Modelo
        {
            get { return modelo; }
           
        }

        public bool SetModelo(string modeloValue)
        {
            if (string.IsNullOrEmpty(modeloValue))
            {
                MessageBox.Show("Modelo invalido");
                return false;

            }
            modelo = modeloValue;
            return true;
        }

        public string Placa
        {
            get { return placa; }
           
        }

        public bool SetPlaca(string placaValue)
        {

            if (string.IsNullOrEmpty(placaValue) || placaValue.Length != 8)
            {
                MessageBox.Show("Placa invalida");
                return false;

            }
            placa = placaValue;
            return true;
        }

        public string Marca
        {
            get { return marca; }
        }

        public bool SetMarca(string marcaValue)
        {
            if (string.IsNullOrEmpty(marcaValue))
            {
                MessageBox.Show("Marca invalida");
                return false;

            }
            marca = marcaValue;
            return true;
        }

        public int Ano
        {
            get { return ano; }
        }

        public bool SetAno(int value)
        {
            if (value < 1769 || value > (DateTime.Now.Year + 1))
            {
                MessageBox.Show("Ano invalido");
                return false;
            }
            ano = value;
            return true;
        }

        public double Quilometragem
        {
            get { return quilometragem; }
        }

        public bool SetQuilometragem(double quilometragemValue)
        {
            if (quilometragemValue < 0)
                {
                    MessageBox.Show("Quilometragem invalida");
                    return false;

                }
                quilometragem = quilometragemValue;
               return true;
        }
        

        public double CapacidadeTanque
        {
            get { return capacidadeTanque; }

        }

        public bool SetCapacidadeTanque(double capacidadeTanqueValue)
        {
            if (capacidadeTanqueValue < 0)
            {
                MessageBox.Show("Capacidade de tanque invalida");
                return false;

            }
            capacidadeTanque = capacidadeTanqueValue;
            return true;


        }

        public double Potencia
        {
            get { return potencia; }
        }

        public bool SetPotencia(double potenciaValue)
        {
            if (potenciaValue < 0)
            {
                MessageBox.Show("Potencia invalida");
                return false;

            }
            potencia = potenciaValue;
            return true;
        }

        public bool ConfigurarCarro(string modeloText, string placaText, string marcaText, string anoText,
            string quilometragemText, string capacidadeTanqueText, string potenciaText)
        {
            int _ano;
            double _quilometragem;
            double _capacidadeTanque;
            double _potencia;
            if (!int.TryParse(anoText, out _ano))
            {
                return false;
            }
            if (!double.TryParse(quilometragemText, out _quilometragem))
            {
                return false;
            }
            if (!double.TryParse(capacidadeTanqueText, out _capacidadeTanque))
            {
                return false;
            }
            if (!double.TryParse(potenciaText, out _potencia))
            {
                return false;
            }

            if (!SetModelo(modeloText))
            {
                return false;
            }

            if (!SetPlaca(placaText))
            {
                return false;
            }
            if (!SetMarca(marcaText))
            {
                return false;
            }
            if (!SetAno(_ano))
            {
                return false;
            }

            if (!SetQuilometragem(_quilometragem))
            {
                return false;
            }
            if (!SetCapacidadeTanque(_capacidadeTanque))
            {
                return false;
            }
            if (!SetPotencia(_potencia))
            {
                return false;
            }
            return true;

        }
    }
}
