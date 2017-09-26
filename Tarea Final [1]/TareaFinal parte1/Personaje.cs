using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Personaje
    {
        public List<Personaje_Caracteristica> Caracteristicas { get; set; }
        public List<Habilidad_Especial> H_EAtributoColeccion { get; set; }
        Listados Listados = new Listados();
        public Raza RazaAtributo { get; set; }
        public Clase ClaseAtributo { get; set; }
        public Controlador Controlador { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Constitucion { get; set; }
        public int Inteligencia { get; set; }
        public int Sabiduria { get; set; }
        public int Carisma { get; set; }
        

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
