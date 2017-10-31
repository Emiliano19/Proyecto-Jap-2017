using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Caracteristica
    {
        public List<Raza> RazaAtributoColeccion { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Caracteristica()
        {
            RazaAtributoColeccion = new List<Raza>();
        }

    }

}
