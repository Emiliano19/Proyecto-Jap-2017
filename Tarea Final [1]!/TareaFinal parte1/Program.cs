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

            Console.WriteLine("       |-----------------------------------------------------------------------------|                       ");
            Console.WriteLine("       |   ___________      ___         ________      _________         ___          |                       ");
            Console.WriteLine("       |  |           -    -   -       |   ___   -   |   ______|       -   -         |                       ");
            Console.WriteLine("       |  |____   ____-   -  -  -      |  |___-   -  |   |            -  -  -        |                       ");
            Console.WriteLine("       |      |   -      -  ___  -     |   __   -    |   ------|     -  ___  -       |                       ");
            Console.WriteLine("       |      |   -     -  _____  -    |   | -  -    |   ------|    -  _____  -      |                       ");
            Console.WriteLine("       |      |   -    -  -     -  -   |   |  -  -   |   |_____    -  -     -  -     |                       ");
            Console.WriteLine("       |      |___-   -__-       -__-  |___|   -__-  |_________|  -__-       -__-    |                       ");
            Console.WriteLine("       |-----------------------------------------------------------------------------|                       ");
            Console.WriteLine();
            Console.WriteLine("                       Bienvenido al Sistema de Control de Personajes                                        ");
            Console.WriteLine();
            Console.WriteLine("A continuación se muestran los comandos de control de Sistema precione Enter para que aparescan");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Crear un Nuevo Personaje Ingrese:        |-Para Crear una Caracteristica Ingrese:                    |");
            Console.WriteLine("|-CrearPersonaje                                |-CrearCaracteristica                                       |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Modificar un Personaje Ingrese:          |-Para Modificar una Caracteristica Ingrese:                |");
            Console.WriteLine("|-ModificarPersonaje                            |-ModificarCaracteristica                                   |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Listar a los Personajes Ingrese:         |-Para Listar una Caracteristica Ingrese                    |");
            Console.WriteLine("|-ListarPersonajes                              |-ListarCaracteristicas                                     |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Eliminar un Personaje Ingrese:           |-Para Eliminar una Caracteristica Ingrese                  |");
            Console.WriteLine("|-EliminarPersonaje                             |-EliminarCaracteristica                                    |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Crear una Raza Ingrese:                  |-Para Crear una Habilidad Especial Ingrese:                |");
            Console.WriteLine("|-CrearRaza                                     |-CrearHabilidadEspecialVariable                            |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Modifficar una Raza:                     |-Para Modificar una Habilidad Especial Ingrese:            |");
            Console.WriteLine("|-ModificarRaza                                 |-ModificarHabilidadEspecial                                |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Listar una Raza:                         |-Para Listar las Habilidades Especiales Ingrese:           |");
            Console.WriteLine("|-ListarRazas                                   |-ListarHabilidadesEspeciales                               |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Eliminar una Raza:                       |-Para Listar las Habilidades Especiales por Clase Ingrese: |");
            Console.WriteLine("|-EliminarRaza                                  |-ListarHabilidadesEspecialesPorClase                       |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Crear una Clase Ingrese:                 |-Para Eliminar una Habilidad Especial Ingrese:             |");
            Console.WriteLine("|-CrearClase                                    |-EliminarHabilidadEspecial                                 |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Modificar una Clase Ingrese:             |-Para Subir de Nivel Ingrese:                              |");
            Console.WriteLine("|-ModificarClase                                |-SubirdeNivel                                              |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ___________________________________________________________________________________________________________ ");
            Console.WriteLine("|-Para Eliminar una Clase Ingrese:              |                                                           |");
            Console.WriteLine("|-EliminarClase                                 |                                                           |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Ingrese el Comando Elegido: ");
            string Comando = Console.ReadLine();
            Console.WriteLine();
            while(!Comando.Equals("FIN"))
            {
                if (Comando == "CrearPersonaje")
                {
                    controlador.CrearPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarPersonaje")
                {   
                    controlador.ModificarPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajes")
                {
                    controlador.ListarPersonajes();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarPersonaje")
                {
                    controlador.EliminarPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorRaza")
                {
                    controlador.ListarPersonajesPorRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorClase")
                {
                    controlador.ListarPersonajesPorClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearRaza")
                {
                    controlador.CrearRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarRaza")
                {
                    controlador.ModificarRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarRazas")
                {
                    controlador.ListarRazas();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarRaza")
                {
                    controlador.EliminarRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearClase")
                {
                    controlador.CrearClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarClase")
                {
                    controlador.ModificarClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarClases")
                {
                    controlador.ListarClases();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarClase")
                {
                    controlador.EliminarClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearCaracteristica"))
                {
                    controlador.CrearCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarCaracteristica")
                {
                    controlador.ModificarCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarCaracteristicas")
                {
                    controlador.ListarCaracteristicas();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarCaracteristica")
                {
                    controlador.EliminarCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearHabilidadEspecial"))
                {
                    controlador.CrearHabilidadHespecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarHabilidadEspecial")
                {
                    controlador.ModificarHabilidadEspecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarHabilidadesEspeciales")
                {
                    controlador.ListarHabilidadesEspeciales();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarHabilidadesEspecialesPorClase")
                {
                    controlador.ListarHabilidadHespecialPorClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarHabilidadEspecial")
                {
                    controlador.EliminarHabilidadEspecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if(Comando == "SubirdeNivel")
                {
                    controlador.SubirdeNivel();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
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
            Console.WriteLine("A culminado con Exito su gestion del Personaje, ahora esta listo para Jugar");
            Console.WriteLine();
            Console.WriteLine("                              _____                                        ");
            Console.WriteLine("                          -           -                                    ");
            Console.WriteLine("                       -   __       __   -                                 ");
            Console.WriteLine("                      -   | .|     |. |   -                                ");
            Console.WriteLine("                      -        |_|        -                                ");
            Console.WriteLine("                       -     -______-    -                                 ");
            Console.WriteLine("                         - _         _ -                                   ");
            Console.WriteLine("                             --___--                                       ");
            Console.WriteLine();
            Console.WriteLine("                               FIN                                         ");
        }
        
    }

}
