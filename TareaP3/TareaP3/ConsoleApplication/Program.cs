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
            CaracteristicaControlador CaracteristicaControlador = new CaracteristicaControlador();
            SubirdeNivel SubirdeNivelControlador = new SubirdeNivel();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                      |-----------------------------------------------------------------------------|               ");
            Console.WriteLine("                      |   ___________      ___         ________      _________         ___          |               ");
            Console.WriteLine("                      |  |           -    -   -       |   ___   -   |   ______|       -   -         |               ");
            Console.WriteLine("                      |  |____   ____-   -  -  -      |  |___-   -  |   |            -  -  -        |               ");
            Console.WriteLine("                      |      |   -      -  ___  -     |   __   -    |   ------|     -  ___  -       |               ");
            Console.WriteLine("                      |      |   -     -  _____  -    |   | -  -    |   ------|    -  _____  -      |               ");
            Console.WriteLine("                      |      |   -    -  -     -  -   |   |  -  -   |   |_____    -  -     -  -     |               ");
            Console.WriteLine("                      |      |___-   -__-       -__-  |___|   -__-  |_________|  -__-       -__-    |               ");
            Console.WriteLine("                      |-----------------------------------------------------------------------------|               ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                      Bienvenido al Sistema de Control de Personajes                              ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("              A continuación se muestran los comandos de control de Sistema presione ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("para que aparezcan    ");
            Console.ReadLine();
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();
            bool ENTRAMAYOR = true;
            while (ENTRAMAYOR)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   1-Personaje         2-Raza            3-Clase            4-Habilidad         5-Característica       6-Comandos Extra    ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("   1-Crear             1-Crear           1-Crear            1-Crear             1-Crear                1-Subir de Nivel    ");
                Console.WriteLine("   2-Modificar         2-Modificar       2-Modificar        2-Modificar         2-Modificar            2-Fin del Programa  ");
                Console.WriteLine("   3-Listar            3-Listar          3-Listar           3-Listar            3-Listar                                   ");
                Console.WriteLine("   4-Listar por Clase  4-Eliminar        4-Eliminar         4-Listar por Clase  4-Eliminar                                 ");
                Console.WriteLine("   5-Listar por Raza                                        5-Eliminar                                                     ");
                Console.WriteLine("   6-Eliminar                                                                                                              ");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Ingrese Valor de la");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Columna");
                Console.ResetColor();
                Console.Write(" elegida: ");
                string ComandoMAYOR = Console.ReadLine();
                int NumMAYOR;
                bool resultMAYOR = Int32.TryParse(ComandoMAYOR, out NumMAYOR);
                if (NumMAYOR != 1 && NumMAYOR != 2 && NumMAYOR != 3 && NumMAYOR != 4 && NumMAYOR != 5 && NumMAYOR != 6 || resultMAYOR == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Comando erróneo, intente de nuevo");
                    Console.WriteLine();
                }
                else if (NumMAYOR == 1)
                {
                    bool Entro1 = true;
                    while (Entro1)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando1 = Console.ReadLine();
                        int Num1;
                        bool result1 = Int32.TryParse(Comando1, out Num1);
                        if (Num1 != 1 && Num1 != 2 && Num1 != 3 && Num1 != 4 && Num1 != 5 && Num1 != 6 || result1 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                        }
                        else if (Num1 == 1)
                        {
                            Console.WriteLine();
                            PersonajeControlador.CrearPersonaje();
                            Entro1 = false;
                        }
                        else if (Num1 == 2)
                        {
                            Console.WriteLine();
                            PersonajeControlador.ModificarPersonaje();
                            Entro1 = false;
                        }
                        else if (Num1 == 3)
                        {
                            Console.WriteLine();
                            PersonajeControlador.ListarPersonajes();
                            Entro1 = false;
                        }
                        else if (Num1 == 4)
                        {
                            Console.WriteLine();
                            PersonajeControlador.ListarPersonajesPorClase();
                            Entro1 = false;
                        }
                        else if (Num1 == 5)
                        {
                            Console.WriteLine();
                            PersonajeControlador.ListarPersonajesPorRaza();
                            Entro1 = false;
                        }
                        else if (Num1 == 6)
                        {
                            Console.WriteLine();
                            PersonajeControlador.EliminarPersonaje();
                            Entro1 = false;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                    Console.WriteLine();

                }
                else if (NumMAYOR == 2)
                {
                    bool Entro2 = true;
                    while (Entro2)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando2 = Console.ReadLine();
                        int Num2;
                        bool result2 = Int32.TryParse(Comando2, out Num2);
                        if (Num2 != 1 && Num2 != 2 && Num2 != 3 && Num2 != 4 || result2 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num2 == 1)
                        {
                            Console.WriteLine();
                            RazaControlador.CrearRaza();
                            Entro2 = false;
                        }
                        else if (Num2 == 2)
                        {
                            Console.WriteLine();
                            RazaControlador.ModificarRaza();
                            Entro2 = false;
                        }
                        else if (Num2 == 3)
                        {
                            Console.WriteLine();
                            RazaControlador.ListarRazas();
                            Entro2 = false;
                        }
                        else if (Num2 == 4)
                        {
                            Console.WriteLine();
                            RazaControlador.EliminarRaza();
                            Entro2 = false;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                    Console.WriteLine();

                }
                else if (NumMAYOR == 3)
                {
                    bool Entro3 = true;
                    while (Entro3)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando3 = Console.ReadLine();
                        int Num3;
                        bool result3 = Int32.TryParse(Comando3, out Num3);
                        if (Num3 != 1 && Num3 != 2 && Num3 != 3 && Num3 != 4 || result3 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num3 == 1)
                        {
                            Console.WriteLine();
                            ClaseControlador.CrearClase();
                            Entro3 = false;
                        }
                        else if (Num3 == 2)
                        {
                            Console.WriteLine();
                            ClaseControlador.ModificarClase();
                            Entro3 = false;
                        }
                        else if (Num3 == 3)
                        {
                            Console.WriteLine();
                            ClaseControlador.ListarClases();
                            Entro3 = false;
                        }
                        else if (Num3 == 4)
                        {
                            Console.WriteLine();
                            ClaseControlador.EliminarClase();
                            Entro3 = false;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                    Console.WriteLine();

                }
                else if (NumMAYOR == 4)
                {
                    bool Entro4 = true;
                    while (Entro4)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando4 = Console.ReadLine();
                        int Num4;
                        bool result4 = Int32.TryParse(Comando4, out Num4);
                        if (Num4 != 1 && Num4 != 2 && Num4 != 3 && Num4 != 4 && Num4 != 5 || result4 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num4 == 1)
                        {
                            Console.WriteLine();
                            HEControlador.CrearHabilidadHespecial();
                            Entro4 = false;
                        }
                        else if (Num4 == 2)
                        {
                            Console.WriteLine();
                            HEControlador.ModificarHabilidadEspecial();
                            Entro4 = false;
                        }
                        else if (Num4 == 3)
                        {
                            Console.WriteLine();
                            HEControlador.ListarHabilidadesEspeciales();
                            Entro4 = false;
                        }
                        else if (Num4 == 4)
                        {
                            Console.WriteLine();
                            HEControlador.ListarHabilidadHespecialPorClase();
                            Entro4 = false;
                        }
                        else if (Num4 == 5)
                        {
                            Console.WriteLine();
                            HEControlador.EliminarHabilidadEspecial();
                            Entro4 = false;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                    Console.WriteLine();

                }
                else if (NumMAYOR == 5)
                {
                    bool Entro5 = true;
                    while (Entro5)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando5 = Console.ReadLine();
                        int Num5;
                        bool result5 = Int32.TryParse(Comando5, out Num5);
                        if (Num5 != 1 && Num5 != 2 && Num5 != 3 && Num5 != 4 || result5 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num5 == 1)
                        {
                            Console.WriteLine();
                            CaracteristicaControlador.CrearCaracteristica();
                            Entro5 = false;
                        }
                        else if (Num5 == 2)
                        {
                            Console.WriteLine();
                            CaracteristicaControlador.ModificarCaracteristica();
                            Entro5 = false;
                        }
                        else if (Num5 == 3)
                        {
                            Console.WriteLine();
                            CaracteristicaControlador.ListarCaracteristicas();
                            Entro5 = false;
                        }
                        else if (Num5 == 4)
                        {
                            Console.WriteLine();
                            CaracteristicaControlador.EliminarCaracteristica();
                            Entro5 = false;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                    Console.WriteLine();

                }
                else if (NumMAYOR == 6)
                {
                    bool Entro6 = true;
                    while (Entro6)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese Valor del");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Comando");
                        Console.ResetColor();
                        Console.Write(" elegido: ");
                        string Comando6 = Console.ReadLine();
                        int Num6;
                        bool result6 = Int32.TryParse(Comando6, out Num6);
                        if (Num6 != 1 && Num6 != 2 || result6 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Comando erróneo, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num6 == 1)
                        {
                            Console.WriteLine();
                            SubirdeNivelControlador.SubirNivel();
                            Entro6 = false;
                        }
                        else if (Num6 == 2)
                        {
                            Entro6 = false;
                            ENTRAMAYOR = false;
                        }
                        Console.WriteLine("Si quiere continuar ingrese el comando elegido a continuación");
                        Console.WriteLine();

                    }
                  
                }         

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                        A culminado con Éxito la gestión del Personaje, ahora está listo para Jugar          ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("                                                           _____                                             ");
            Console.WriteLine("                                                       -           -                                         ");
            Console.WriteLine("                                                    -   __       __   -                                      ");
            Console.WriteLine("                                                   -   | .|     |. |   -                                     ");
            Console.WriteLine("                                                   -        |_|        -                                     ");
            Console.WriteLine("                                                    -     -______-    -                                      ");
            Console.WriteLine("                                                      - _         _ -                                        ");
            Console.WriteLine("                                                          --___--                                            ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                           F I N                                             ");
            Console.ResetColor();
            Console.ReadLine();
        }

    }

}
