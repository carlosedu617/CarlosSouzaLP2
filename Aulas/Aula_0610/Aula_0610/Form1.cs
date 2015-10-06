using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_0610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Amigo> amigos = new List<Amigo>();
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Amigo amigo = new Amigo();
            amigo.Nome = tbNome.Text;
            amigo.Sobrenome = tbSobrenome.Text;
            amigo.Presente1 = tbPresente1.Text;
            amigo.Presente2 = tbPresente2.Text;
            amigo.Presente3 = tbPresente3.Text;

            amigos.Add(amigo);


            tbNome.Clear();
            tbSobrenome.Clear();
            tbPresente1.Clear();
            tbPresente2.Clear();
            tbPresente3.Clear();

            ConectarBD bd = new ConectarBD();
            string q = string.Format("INSERT INTO Amigo(Nome,Sobrenome,Presente1,Presente2,Presente3)VALUES('{0}','{1}','{2}','{3}','{4}')",amigo.Nome , amigo.Sobrenome , amigo.Presente1 , amigo.Presente2 , amigo.Presente3);

            bd.InserirRegistro(q);

        }

       
    }
}
