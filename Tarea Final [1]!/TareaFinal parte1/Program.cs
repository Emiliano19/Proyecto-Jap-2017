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
            Console.WriteLine("Para Listar a los Personajes Ingrese:");
            Console.WriteLine("ListarPersonajes");
            Console.WriteLine("Para Eliminar un Personaje Ingrese:");
            Console.WriteLine("EliminarPersonaje");
            Console.WriteLine("Para Crear una Raza Ingrese:");
            Console.WriteLine("CrearRaza");
            Console.WriteLine("Para Modificar una Raza Ingrese:");
            Console.WriteLine("ModificarRaza");
            Console.WriteLine("Para Listar las Razas Ingrese:");
            Console.WriteLine("ListarRazas");
            Console.WriteLine("Para Eliminar una Raza Ingrese:");
            Console.WriteLine("EliminarRaza");
            Console.WriteLine("Para Crear una nueva Clase Ingrese:");
            Console.WriteLine("CrearClase");
            Console.WriteLine("Para Modificar una Clase Ingrese:");
            Console.WriteLine("ModificarClase");
            Console.WriteLine("Para Listar las Clases Ingrese:");
            Console.WriteLine("ListarClases");
            Console.WriteLine("Para Eliminar una Clase Ingrese:");
            Console.WriteLine("EliminarClase");
            Console.WriteLine("Para Crear una Caracteristica Variable Ingrese:");
            Console.WriteLine("CrearCaracteristica");
            Console.WriteLine("Para Modificar una Caracteristica Variable Ingrese:");
            Console.WriteLine("ModificarCaracteristica");
            Console.WriteLine("Para Listar las Caracteristicas Ingrese:");
            Console.WriteLine("ListarCaracteristicas");
            Console.WriteLine("Para Elimina una Caracteristica Variable Ingrese:");
            Console.WriteLine("EliminarCaracteristica");
            Console.WriteLine("Para Crear una Habilidad Especial Ingrese:");
            Console.WriteLine("CrearHabilidadEspecialVariable");
            Console.WriteLine("Para Modificar una Habilidad Especial Ingrese:");
            Console.WriteLine("ModificarHabilidadEspecial");
            Console.WriteLine("Para Listar las Habilidades Especiales Ingrese:");
            Console.WriteLine("ListarHabilidadesEspeciales");
            Console.WriteLine("Para Eliminar una Habilidad Especial Ingrese:");
            Console.WriteLine("EliminarHabilidadEspecial");
            Console.WriteLine();
            Console.Write("Ingrese el Comando Elegido: ");
            string Comando = Console.ReadLine();
           

            Console.WriteLine();
            while(!Comando.Equals("Fin"))
            {
                if (Comando == "CrearPersonaje")
                {
                    controlador.CrearPersonaje();
                    Console.WriteLine();
                    Console.WriteLine("Se ingresaron correctamente los datos generales del Personaje");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarPersonaje")
                {   
                    controlador.ModificarPersonaje();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                if (Comando == "ListarPersonajes")
                {
                    controlador.ListarPersonajes();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarPersonaje")
                {
                    controlador.EliminarPersonaje();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorRaza")
                {
                    controlador.ListarPersonajesPorRaza();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorClase")
                {
                    controlador.ListarPersonajesPorClase();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearRaza")
                {
                    controlador.CrearRaza();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarRaza")
                {
                    controlador.ModificarRaza();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                if (Comando == "ListarRazas")
                {
                    controlador.ListarRazas();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarRaza")
                {
                    controlador.EliminarRaza();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearClase")
                {
                    controlador.CrearClase();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarClase")
                {
                    controlador.ModificarClase();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                if (Comando == "ListarClases")
                {
                    controlador.ListarClases();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarClase")
                {
                    controlador.EliminarClase();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearCaracteristica"))
                {
                    controlador.CrearCaracteristica();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarCaracteristica")
                {
                    controlador.ModificarCaracteristica();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                if (Comando == "ListarCaracteristicas")
                {
                    controlador.ListarCaracteristicas();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarCaracteristica")
                {
                    controlador.EliminarCaracteristica();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearHabilidadEspecial"))
                {
                    controlador.CrearHabilidadHespecial();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarHabilidadEspecial")
                {
                    controlador.ModificarHabilidadEspecial();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                if (Comando == "ListarHabilidadesEspeciales")
                {
                    controlador.ListarHabilidadesEspeciales();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarHabilidadEspecial")
                {
                    controlador.EliminarHabilidadEspecial();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Comando Erroneo vuelva a Intentar");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                Console.WriteLine();
 
            }
        }
        
        
    }
}
