using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Caracteristica_Variable
    {
        public List<Raza> RazaAtributoColeccion { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Caracteristica_Variable()
        {
            RazaAtributoColeccion = new List<Raza>();
           
        }

        public static implicit operator Caracteristica_Variable(Personaje_Caracteristica v)
        {
            throw new NotImplementedException();
        }
    }
}
