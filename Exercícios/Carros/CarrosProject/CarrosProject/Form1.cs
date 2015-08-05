using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosProject
{
    public partial class JanelaBuscaCarro : Form
    {
        private List<Carro> carros = new List<Carro>();

        public JanelaBuscaCarro()
        {
            InitializeComponent();
        }

        private void BtnBuscarPlaca_Click(object sender, EventArgs e)
        {

            Carro carro = BuscarCarro(TbBuscarPlaca.Text);
            if (carro == null)
            {
                MessageBox.Show("Placa não registrada");

            }
            else
            {
                MessageBox.Show("Placa encontrada com sucesso");
                TbModelo.Text = carro.Modelo;
                TbPlaca.Text = carro.Placa;
                TbMarca.Text = carro.Marca;
                TbAno.Text = carro.Ano.ToString();
                TbQuilometragem.Text = carro.Quilometragem.ToString();
                TbCapacidadeTanque.Text = carro.CapacidadeTanque.ToString();
                TbPotencia.Text = carro.Potencia.ToString();
                TbBuscarPlaca.Clear();
            }

        }

        private void BtnSalvarCarro_Click(object sender, EventArgs e)
        {
            Carro carro = BuscarCarro(TbPlaca.Text);
            if (carro == null)
            {
                carro = new Carro();
            }
            if (carro.ConfigurarCarro(TbModelo.Text, TbPlaca.Text, TbMarca.Text, TbAno.Text, TbQuilometragem.Text,
                TbCapacidadeTanque.Text, TbPotencia.Text))
            {

                if (!carros.Contains(carro))
                {
                    carros.Add(carro);
                    MessageBox.Show("Carro criado com sucesso");
                }
                else
                {
                    MessageBox.Show("Carro atualizado com sucesso");
                }
                TbModelo.Clear();
                TbPlaca.Clear();
                TbMarca.Clear();
                TbAno.Clear();
                TbQuilometragem.Clear();
                TbCapacidadeTanque.Clear();
                TbPotencia.Clear();

            }
            else
            {
                MessageBox.Show("Não foi possivel criar o carro");
            }
        }

        public Carro BuscarCarro(string placa)
        {
            foreach (Carro carro in carros)
            {
                if (carro.Placa == placa)
                {
                    return carro;

                }
            }
            return null;

        }

    }
}
