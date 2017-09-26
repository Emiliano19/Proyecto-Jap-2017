using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Raza
    {
        public static Listados Listados = new Listados();
        public List<Personaje> PersonajeAtributoColeccion { get; set; }
        public Caracteristica_Variable Caract_VarRazaAtributo { get; set; }
        public Personaje PersonajeAtributo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Raza(int id, string nombre, string descripcion)
        {
             this.Id = id;
             this.Nombre = nombre;
             this.Descripcion = descripcion;
        }

        public Raza()
        {

        }

    }
}
