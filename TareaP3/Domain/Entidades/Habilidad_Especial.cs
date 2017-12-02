using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Habilidad_Especial
    {
        public List<Clase> ClaseAtributoColeccion { get; set; }
        public Clase ClaseAtributo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return this.Id + ", " + this.Nombre + ", " + this.Descripcion;
        }

        public Habilidad_Especial()
        {
           
        }

    }

}
