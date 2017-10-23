using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;
using ConsoleApplication.Controladores;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonajeControlador PersonajeControlador = new PersonajeControlador();
            RazaControlador RazaControlador = new RazaControlador();
            ClaseControlador ClaseControlador = new ClaseControlador();
            Habilidad_EspecialControlador HEControlador = new Habilidad_EspecialControlador();
            CaracteristicaControlador CaracteristicasControlador = new CaracteristicaControlador();
            SubirdeNivel SubirdeNivelControlador = new SubirdeNivel();

            Console.WriteLine("        |-----------------------------------------------------------------------------|                      ");
            Console.WriteLine("        |   ___________      ___         ________      _________         ___          |                      ");
            Console.WriteLine("        |  |           -    -   -       |   ___   -   |   ______|       -   -         |                      ");
            Console.WriteLine("        |  |____   ____-   -  -  -      |  |___-   -  |   |            -  -  -        |                      ");
            Console.WriteLine("        |      |   -      -  ___  -     |   __   -    |   ------|     -  ___  -       |                      ");
            Console.WriteLine("        |      |   -     -  _____  -    |   | -  -    |   ------|    -  _____  -      |                      ");
            Console.WriteLine("        |      |   -    -  -     -  -   |   |  -  -   |   |_____    -  -     -  -     |                      ");
            Console.WriteLine("        |      |___-   -__-       -__-  |___|   -__-  |_________|  -__-       -__-    |                      ");
            Console.WriteLine("        |-----------------------------------------------------------------------------|                      ");
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
            while (!Comando.Equals("FIN"))
            {
                if (Comando == "CrearPersonaje")
                {
                    PersonajeControlador.CrearPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarPersonaje")
                {
                    PersonajeControlador.ModificarPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajes")
                {
                    PersonajeControlador.ListarPersonajes();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarPersonaje")
                {
                    PersonajeControlador.EliminarPersonaje();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorRaza")
                {
                    PersonajeControlador.ListarPersonajesPorRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarPersonajesPorClase")
                {
                    PersonajeControlador.ListarPersonajesPorClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearRaza")
                {
                    RazaControlador.CrearRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarRaza")
                {
                    RazaControlador.ModificarRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarRazas")
                {
                    RazaControlador.ListarRazas();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarRaza")
                {
                    RazaControlador.EliminarRaza();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "CrearClase")
                {
                    ClaseControlador.CrearClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarClase")
                {
                    ClaseControlador.ModificarClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarClases")
                {
                    ClaseControlador.ListarClases();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarClase")
                {
                    ClaseControlador.EliminarClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearCaracteristica"))
                {
                    CaracteristicasControlador.CrearCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarCaracteristica")
                {
                    CaracteristicasControlador.ModificarCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarCaracteristicas")
                {
                    CaracteristicasControlador.ListarCaracteristicas();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarCaracteristica")
                {
                    CaracteristicasControlador.EliminarCaracteristica();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando.Equals("CrearHabilidadEspecial"))
                {
                    HEControlador.CrearHabilidadHespecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ModificarHabilidadEspecial")
                {
                    HEControlador.ModificarHabilidadEspecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarHabilidadesEspeciales")
                {
                    HEControlador.ListarHabilidadesEspeciales();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "ListarHabilidadesEspecialesPorClase")
                {
                    HEControlador.ListarHabilidadHespecialPorClase();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "EliminarHabilidadEspecial")
                {
                    HEControlador.EliminarHabilidadEspecial();
                    Console.WriteLine("Si quiere realizr mas cambios elija un comando de la lista de lo contrario ingrese FIN");
                    Console.WriteLine();
                    Console.Write("Ingrese el Nuevo Comando Elegido: ");
                    Comando = Console.ReadLine();
                }
                else if (Comando == "SubirdeNivel")
                {
                    SubirdeNivelControlador.SubirNivel();
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
            Console.WriteLine("     A culminado con Exito su gestion del Personaje, ahora esta listo para Jugar       ");
            Console.WriteLine();
            Console.WriteLine("                                     _____                                             ");
            Console.WriteLine("                                 -           -                                         ");
            Console.WriteLine("                              -   __       __   -                                      ");
            Console.WriteLine("                             -   | .|     |. |   -                                     ");
            Console.WriteLine("                             -        |_|        -                                     ");
            Console.WriteLine("                              -     -______-    -                                      ");
            Console.WriteLine("                                - _         _ -                                        ");
            Console.WriteLine("                                    --___--                                            ");
            Console.WriteLine();
            Console.WriteLine("                                      FIN                                              ");
            Console.ReadLine();
        }
    }
}
