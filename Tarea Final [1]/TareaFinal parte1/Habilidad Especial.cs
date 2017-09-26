using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Habilidad_Especial
    {
        public List<Clase> ClaseAtributoColeccion { get; set; }
        Listados Listados = new Listados();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        public Habilidad_Especial(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public Habilidad_Especial()
        {
           
            //   ClaseAtributoColeccion = Listados.Clase_List;
        }
    }
}
