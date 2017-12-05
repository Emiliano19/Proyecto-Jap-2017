using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Personaje
    {
        public List<Personaje_Caracteristica> C_VAtributoColeccion { get; set; }
        public List<Habilidad_Especial> H_EAtributoColeccion { get; set; }
        public Personaje_Caracteristica Persona_Carac { get; set; }
        public Habilidad_Especial H_EAtributo { get; set; }
        public Raza RazaAtributo { get; set; }
        public Clase ClaseAtributo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Constitucion { get; set; }
        public int Inteligencia { get; set; }
        public int Sabiduria { get; set; }
        public int Carisma { get; set; }

        public override string ToString()
        {
            return this.Id + ", " + this.Nombre + ", " + this.Nivel + ", " + this.Fuerza + ", " + this.Destreza + ", " + this.Constitucion + ", " + this.Inteligencia + ", " + this.Sabiduria + ", " + this.Carisma;
        }
        public Personaje()
        {
            C_VAtributoColeccion = new List<Personaje_Caracteristica>();
            H_EAtributoColeccion = new List<Habilidad_Especial>();
        }

    }

}
