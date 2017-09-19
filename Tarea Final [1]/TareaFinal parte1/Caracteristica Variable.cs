using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Caracteristica_Variable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Caracteristica_Variable(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
       
    }
}
