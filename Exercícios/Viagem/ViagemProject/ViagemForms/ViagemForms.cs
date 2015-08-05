using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViagemProject;


namespace ViagemForms
{
    public partial class ViagemForms : Form
    {
        public ViagemForms()
        {
            InitializeComponent();

        }


        List<Carro> listaCarros = new List<Carro>();
        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
            Carro carro = GerarCarro();
            if (carro == null)
            {
                return;
            }
            AdicionarCarro(carro);
            ApagarFormulario();
            MessageBox.Show("Carro criado com sucesso");
        }
        private Carro GerarCarro()
        {
            Carro carro = new Carro();
            carro.Modelo = tbModelo.Text;
            carro.Marca = tbMarca.Text;
            carro.Placa = tbPlaca.Text;
            carro.Lugares = carro.Vagas = int.Parse(tbNumeroLugares.Text);
            if (ValidarPlaca(carro) == true && ValidaLugares(carro) == true)
            {              
               return carro;                              
            }
            return null;
        }

        private bool ValidarPlaca(Carro carro)
        {
            if (carro.Placa.Length != 8)
            {
                MessageBox.Show("Placa invalida");
                return false;
            }
            return true;

        }

        private bool ValidaLugares(Carro carro)
        {
            if (carro.Lugares < 0 )
            {
                MessageBox.Show("Quantidade de lugares invalida");
                return false;
            }
            return true; 
        }

        private void ApagarFormulario()
        {
            tbMarca.Clear();
            tbModelo.Clear();
            tbNumeroLugares.Clear();
            tbPlaca.Clear();
            
        }

        private void AdicionarCarro(Carro carro)
        {
            foreach (var c in listaCarros)
            {
                if (c.Placa == carro.Placa)
                {
                    MessageBox.Show("Carro ja foi registrado");
                    return;
                }


            }
            listaCarros.Add(carro);


        }

        private void btnEntrarCarro_Click(object sender, EventArgs e)
        {
            int idCarroEntrada = int.Parse(tbCarroEntrada.Text);
            Carro carro = BuscarCarroPorId(idCarroEntrada);
             if (idCarroEntrada == -1)
            {
                tbRelatorio.Clear();
                for (int i = 0; i < listaCarros.Count; i++)
                {
                    Carro _c = listaCarros[i];
                    tbRelatorio.AppendText(Environment.NewLine + "Carro " + _c.Id+ ": " + _c.Modelo + " - " + _c.Marca + " (" + _c.Placa + ")");
                    tbRelatorio.AppendText(Environment.NewLine+"Passageiro: " + _c.Passageiros);
                    if (_c.Vagas == 0)
                    {
                        tbRelatorio.AppendText(Environment.NewLine + "Carro cheio");
                    }
                    else
                    {
                        tbRelatorio.AppendText(Environment.NewLine+"Vagas restantes: "+_c.Vagas);
                    }
                }
                return;
                
            }
            if (carro == null)
            {
                MessageBox.Show("Esse carro não foi registrado");
                return;
            }
            if (carro.AdicionarPassageiros(1) == true)
            {
            MessageBox.Show("Passageiro adicionado");
            }
            else
            {
                MessageBox.Show("Carro cheio");

            }
           


            
        }
        private Carro BuscarCarroPorId(int id)
        {
            foreach (var carro in listaCarros)
            {
                if (carro.Id == id)
                {
                    return carro;
                }
            }

            return null;

        }

      
    }
}
