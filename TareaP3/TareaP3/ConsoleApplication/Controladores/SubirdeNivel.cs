using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class SubirdeNivel
    {
        public void SubirNivel()
        {
            Console.WriteLine("Seleccione el Personaje al que le quiere subir de Nivel de la siguiente lista");
            Console.WriteLine();
            foreach (Personaje PL in BusinessLogic.PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(PL.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(PL.Nombre);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" => ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nivel: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PL.Nivel);
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine();
            bool Entro = true;
            while (Entro)
            {
                Console.Write("Ingrese el Id del Personaje elegido: ");
                string Comando = Console.ReadLine();
                int IdP;
                bool result = Int32.TryParse(Comando, out IdP);
                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto para un Id, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Personaje PE = PersonajeBL.Obtener(IdP);
                    Console.WriteLine("Como su Personaje subirá de nivel puede adquirir una Habilidad a elección de la siguiente lista");
                    Console.WriteLine();
                    Clase C = ClaseBL.Obtener(PE.ClaseAtributo.Id);
                    foreach (Habilidad_Especial H in HabilidadEspecialBL.Listar())
                    {
                        Clase_HE CLH = Clase_HEBL.Obtener(C.Id, H.Id);
                        if (CLH != null)
                        {
                            Personaje_HE PHE = Personaje_HEBL.Obtener(PE.Id, H.Id);
                            if (PHE == null)
                            {
                                Console.Write("Id: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(H.Id);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(", Nombre: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(H.Nombre);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(", Descripción: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(H.Descripcion);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }

                    }
                    bool Entrod = true;
                    while (Entrod)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el Id de la Habilidad elegida: ");
                        string Comandod = Console.ReadLine();
                        int IdH;
                        bool resultd = Int32.TryParse(Comandod, out IdH);
                        if (resultd == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto para un Id, intente de nuevo");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Habilidad_Especial H = HabilidadEspecialBL.Obtener(IdH);
                            Personaje_HEBL.Agregar(PE, H);
                            Entrod = false;
                        }
 
                    }
                    bool EntroW = true;
                    while (EntroW)
                    {
                        if (PE.Nivel == 10)
                        {
                            Console.WriteLine("El Nivel de su Personaje no aumentara pues ya está en la máxima capacidad permitida");
                            EntroW = false;
                            Entro = false;
                            Console.WriteLine();
                        }
                        else if (PE.Nivel % 2 != 0 && PE.Nivel != 10 && PE.Nivel != 1)
                        {
                            Console.WriteLine("Como su personaje tiene nivel impar puede subirle 1 punto a una de sus Características Fijas");
                            Console.WriteLine();
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("1 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Fuerza");
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("2 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Destreza");
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("3 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Constitución");
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("4 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Inteligencia");
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("5 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Sabiduria");
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("6 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("=> ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Carisma");
                            Console.WriteLine();
                            bool EntroN = true;
                            if (PE.Fuerza == 10 && PE.Destreza == 10 && PE.Constitucion == 10 && PE.Inteligencia == 10 && PE.Sabiduria == 10 && PE.Carisma == 10)
                            {
                                Console.WriteLine("Su Personaje ya posee todas sus Características al máximo potencial por eso no tedra incremento en ninguna de ellas");
                                Console.WriteLine();
                                Entrod = false;
                                EntroW = false;
                                Entro = false;
                                EntroN = false;
                            }
                            while (EntroN)
                            {
                                Console.Write("Ingrese el Id de la Característica elegida: ");
                                string ComandoN = Console.ReadLine();
                                int Nume;
                                bool resultN = Int32.TryParse(Comando, out Nume);
                                if (Nume != 1 && Nume != 2 && Nume != 3 && Nume != 4 && Nume != 5 && Nume != 6 || result == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Lo que ingreso no es un valor o un tipo de valor correcto, intente de nuevo");
                                    Console.WriteLine();
                                }
                                else if (Nume == 1)
                                {
                                    if (PE.Fuerza == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("La Fuerza ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Fuerza < 10)
                                    {
                                        PE.Fuerza = PE.Fuerza + 1;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }
                                else if (Nume == 2)
                                {
                                    if (PE.Destreza == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("La Destreza ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Destreza < 10)
                                    {
                                        PE.Destreza = PE.Destreza + 1;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }
                                else if (Nume == 3)
                                {
                                    if (PE.Constitucion == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("La Constitución ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Constitucion < 10)
                                    {
                                        PE.Constitucion = PE.Constitucion + 1;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;                                       
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }
                                else if (Nume == 4)
                                {
                                    if (PE.Inteligencia == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("La Inteligencia ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Inteligencia < 10)
                                    {
                                        PE.Inteligencia = PE.Inteligencia + 1;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }
                                else if (Nume == 5)
                                {
                                    if (PE.Sabiduria == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("La Sabiduría ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Sabiduria < 10)
                                    {
                                        PE.Sabiduria = PE.Sabiduria + 1;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }
                                else if (Nume == 6)
                                {
                                    if (PE.Carisma == 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("El Carisma ya está en su máximo Valor y no se puede aumentar, intente con otra");
                                        Console.WriteLine();
                                    }
                                    else if (PE.Carisma < 10)
                                    {
                                        PE.Carisma = PE.Carisma;
                                        PE.Nivel = PE.Nivel + 1;
                                        PersonajeBL.Modificar(PE);
                                        EntroW = false;
                                        Entrod = false;
                                        EntroN = false;
                                        Entro = false;
                                        Console.WriteLine();
                                    }

                                }

                            }

                        }
                        else
                        {
                            PE.Nivel = PE.Nivel + 1;
                            PersonajeBL.Modificar(PE);
                            EntroW = false;
                            Entrod = false;
                            Entro = false;

                        }

                    }

                }

            }

        }

    }

}
