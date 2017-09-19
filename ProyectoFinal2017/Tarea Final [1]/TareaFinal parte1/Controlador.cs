using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Controlador : ISistema
    {
        public Personaje Caracteristica { get; set; }


        public void CrearHabilidadHespecial()
        {

        }
        public void ModificarHabilidadEspecial()
        {

        }
        public void ListarHabilidadesHespeciales()
        {

        }
        public void ListarHabilidadesHespecialesPorClase()
        {

        }
        public void EliminarHabilidadEspecialPorHabilidadEspecial()
        {

        }
        public void CrearClase()
        {

        }
        public void ModificarClase()
        {

        }
        public void ListarClases()
        {

        }
        public void EliminarClase()
        {

        }
        public void CrearRaza()
        {

        }
        public void ModificarRaza()
        {

        }
        public void ListarRazas()
        {

        }
        public void Eliminarraza()
        {

        }

        public void CrearCaracteristica()
        {

        }
        public void Modificarcaracteristica()
        {

        }
        public void ListarCaracteristicas()
        {

        }
        public void EliminarCaracteristica()
        {

        }
        public void CrearPersonaje()
        {
            
            Personaje PersonajeX = new Personaje();
            PersonajeX.Nivel = 3; 
            Console.WriteLine("Ingrese Nuevo Personaje");
            Console.WriteLine("Ingrese Nombre del Personaje");
            PersonajeX.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Nivel del Personaje");
            PersonajeX.Nivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Fuerza del Personaje");
            PersonajeX.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Desztreza del Personaje");
            PersonajeX.Destreza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Constitución del Personaje");
            PersonajeX.Constitucion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Inteligencia del Personaje");
            PersonajeX.Destreza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Sabiduria del Personaje");
            PersonajeX.Sabiduria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Carisma del Personaje");
            PersonajeX.Carisma = int.Parse(Console.ReadLine());
            Console.WriteLine(PersonajeX.Nombre);
            Console.Write("Nivel");
            Console.Write("");
            Console.WriteLine(PersonajeX.Nivel);

        }

        public void ModificarPersonaje()
        {

        }
        public void ListarPersonaje()
        {

        }
        public void ListarPersonajesPorRaza()
        {

        }
        public void ListarPersonajesPorClase()
        {

        }
        public void EliminarPersonaje()
        {

        }
    }
}
