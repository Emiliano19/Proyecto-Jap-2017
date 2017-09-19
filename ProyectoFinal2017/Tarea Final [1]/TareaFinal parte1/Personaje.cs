using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Personaje
    {
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        Controlador Controlador { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Constitucion { get; set; }
        public int Inteligencia { get; set; }
        public int Sabiduria { get; set; }
        public int Carisma { get; set; }
        public Dictionary<int, Personaje_Caracteristica> Caracteristicas { get; set; }

        /*public Personaje(int id, string nombre, int nivel, int fuerza, int destreza, int constitucion, int inteligencia, int sabiduria, int carisma)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Fuerza = fuerza;
            this.Destreza = destreza;
            this.Constitucion = constitucion;
            this.Inteligencia = inteligencia;
            this.Sabiduria = sabiduria;
            this.Carisma = carisma;
        }*/

        public Personaje()
        {
     
        }
    }
}
