using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Raza
    {
        public List<Personaje> PersonajeAtributoColeccion { get; set; }
        public Caracteristica_Variable Caract_VarRazaAtributo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ValorPluss { get; set; }

        public Raza()
        {
            PersonajeAtributoColeccion = new List<Personaje>();
        }

    }
}
