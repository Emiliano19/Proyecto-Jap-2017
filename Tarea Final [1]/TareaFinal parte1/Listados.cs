using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Listados
    {
        public Raza Raza { get; set; }
        public List<Raza> Raza_List = new List<Raza>();
        public Personaje Personaje { get; set; }
        public List<Personaje> Personaje_List = new List<Personaje>();
        public Clase Clase{ get; set; }
        public List<Clase> Clase_List = new List<Clase>();
        public Caracteristica_Variable Caracteristica_Variable { get; set; }
        public List<Caracteristica_Variable> Caracteristica_Variabli_List;
        public Habilidad_Especial Habilidad_Especial { get; set; }
        public List<Habilidad_Especial> Habilidad_Especial_List;
       
    }
}
