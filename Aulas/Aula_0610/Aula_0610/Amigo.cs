using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0610
{
    class Amigo:ConectarBD
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Presente1 { get; set; }
        public string Presente2 { get; set; }
        public string Presente3 { get; set; }
    }
}
