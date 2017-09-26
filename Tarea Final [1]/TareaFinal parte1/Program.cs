using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            Listados Listados = new Listados();
            Fabrica Fabric = new Fabrica();
            ISistema controlador = Fabric.ControladorPersonaje();
            

            Console.WriteLine("Bienvenido al Sistema de Control de Personajes");
            Console.ReadLine();
            Console.WriteLine("A continuación se muestran los comandos de control de Sistema");
            Console.ReadLine();
            Console.WriteLine("Para Crear un Nuevo Personaje Ingrese:");
            Console.WriteLine("CrearPersonaje");
            Console.WriteLine("Para Modificar un Personaje Ingrese:");
            Console.WriteLine("ModificarPersonaje");
            Console.WriteLine("Para Eliminar un Personaje Ingrese:");
            Console.WriteLine("EliminarPersonaje");
            Console.WriteLine("Para Crear una Raza Ingrese:");
            Console.WriteLine("CrearRaza");
            Console.WriteLine("Para Modificar una Raza Ingrese:");
            Console.WriteLine("ModificarRaza");
            Console.WriteLine("Para Eliminar una Raza Ingrese:");
            Console.WriteLine("EliminarRaza");
            Console.WriteLine("Para Crear una nueva Clase Ingrese:");
            Console.WriteLine("CrearClase");
            Console.WriteLine("Para Modificar una Clase Ingrese:");
            Console.WriteLine("ModificarClase");
            Console.WriteLine("Para Eliminar una Clase Ingrese:");
            Console.WriteLine("EliminarClase");
            Console.WriteLine("Para Crear una Caracteristica Ingrese:");
            Console.WriteLine("CrearCaracteristica");
            Console.WriteLine("Para Modificar una Caracteristica Ingrese:");
            Console.WriteLine("ModificarCaracteristica");
            Console.WriteLine("Para Elimina una Caracteristica Ingrese:");
            Console.WriteLine("EliminarCaracteristica");
            Console.WriteLine("Para Crear una Habilidad Especial Ingrese:");
            Console.WriteLine("CrearHabilidadEspecial");
            Console.WriteLine("Para Modificar una Habilidad Especial Ingrese:");
            Console.WriteLine("ModificarHabilidadEspecial");
            Console.WriteLine("Para Eliminar una Habilidad Especial Ingrese:");
            Console.WriteLine("EliminarHabilidadEspecialPorHabilidadEspecial");
            Console.ReadLine();
            Console.Write("Ingrese el Comando Elegido: ");
            string Comando = Console.ReadLine();
           

            Console.WriteLine();
            while(!Comando.Equals("Fin"))
            {
                if (Comando == "CrearPersonaje")
                {
                    controlador.CrearPersonaje();
                    Console.WriteLine("Se ingresaron correctamente los datos generales del Personaje");

                }
                else if (Comando == "ModificarPersonaje")
                {   
                    controlador.ModificarPersonaje();
                }
                else if (Comando == "EliminarPersonaje")
                {
                    controlador.EliminarPersonaje();
                }
                else if (Comando == "CrearRaza")
                {
                    controlador.CrearRaza();
                }
                else if (Comando == "ModificarRaza")
                {
                    controlador.ModificarRaza();
                }
                else if (Comando == "EliminarRaza")
                {
                    controlador.EliminarRaza();
                }
                else if (Comando == "CrearClase")
                {
                    controlador.CrearClase();
                }
                else if (Comando == "ModificarClase")
                {
                    controlador.ModificarClase();
                }
                else if (Comando == "EliminarClase")
                {
                    controlador.EliminarClase();
                }
                else if (Comando.Equals("CrearHE"))
                {
                    controlador.CrearHabilidadHespecial();
                }
                else if (Comando == "ModificarHE")
                {
                        controlador.ModificarHabilidadEspecial();
                }
                else if (Comando == "EliminarHEPorHB")
                {
                    controlador.EliminarHabilidadEspecialPorHabilidadEspecial();
                }
                else if (Comando != "CrearPersonaje")
                {
                    Console.WriteLine("Comando Erroneo vuelva a Intentar");
                    Comando = Console.ReadLine();
                }
                Console.WriteLine();
 
            }
        }
        
        
    }
}
