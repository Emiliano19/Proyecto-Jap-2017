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
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public ClaseControlador ClaseControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador { get; set; }
        public CaracteristicaControlador CaracteristicasControlador { get; set; }


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
                Console.Write(" -> Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PL.Nombre);
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
                    Console.WriteLine("Como su Personaje subira de nivel puede adquirir una Habilidad a elección de la siguiente lista");
                    Console.WriteLine();
                    Clase C = ClaseBL.Obtener(PE.ClaseAtributo.Id);
                    foreach (Habilidad_Especial H in HabilidadEspecialBL.Listar())
                    {
                        Clase_HE CLH = Clase_HEBL.Obtener(C.Id, H.Id);
                        if (CLH != null)
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
                            if (PE.Nivel % 2 != 0 && PE.Nivel != 1)
                            {
                                bool EntroN = true;
                                Console.WriteLine("Como su personaje tiene nivel impar puede subirle 1 punto a una de sus Características Fijas");
                                Console.WriteLine();
                                if(PE.Fuerza == 10 || PE.Destreza == 10 || PE.Constitucion == 10 || PE.Inteligencia == 10 || PE.Sabiduria == 10 || PE.Carisma == 10)
                                {
                                    Console.WriteLine("Su Personaje ya posee todas sus Características al maximo potencial por eso no tedra incremento en ninguna de ellas");
                                    Entrod = false;
                                    Entro = false;
                                    EntroN = false;
                                }
                                while (EntroN)
                                {
                                    Console.WriteLine();
                                    Console.Write("Ingrese el Id de la Característica elegida: ");
                                    string ComandoN = Console.ReadLine();
                                    int Nume;
                                    bool resultN = Int32.TryParse(Comando, out Nume);
                                    if (Nume != 1 && Nume != 2 && Nume != 3 && Nume != 4 && Nume != 5 && Nume != 6 || result == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Lo que ingreso no es un valor o un tipo de valor correcto, intente denuevo");
                                        Console.WriteLine();
                                    }
                                    else if (Nume == 1)
                                    {
                                        if (PE.Fuerza == 10)
                                        {
                                            Console.WriteLine("La Fuerza ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Fuerza < 10)
                                        {
                                            PE.Fuerza = PE.Fuerza + 1;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                    
                                    }
                                    else if (Nume == 2)
                                    {
                                        if (PE.Destreza == 10)
                                        {
                                            Console.WriteLine("La Destreza ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Destreza < 10)
                                        {
                                            PE.Destreza = PE.Destreza + 1;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                   
                                    }
                                    else if (Nume == 3)
                                    {
                                        if (PE.Constitucion == 10)
                                        {
                                            Console.WriteLine("La Constitución ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Constitucion < 10)
                                        {
                                            PE.Constitucion = PE.Constitucion + 1;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                       
                                    }
                                    else if (Nume == 4)
                                    {
                                        if (PE.Inteligencia == 10)
                                        {
                                            Console.WriteLine("La Inteligencia ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Inteligencia < 10)
                                        {
                                            PE.Inteligencia = PE.Inteligencia + 1;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                      
                                    }
                                    else if (Nume == 5)
                                    {
                                        if (PE.Sabiduria == 10)
                                        {
                                            Console.WriteLine("La Sabiduria ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Sabiduria < 10)
                                        {
                                            PE.Sabiduria = PE.Sabiduria + 1;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                      
                                    }
                                    else if (Nume == 6)
                                    {
                                        if (PE.Carisma == 10)
                                        {
                                            Console.WriteLine("El Carisma ya esta en su maximo Valor y no se puede aumentar, ingrese con otra");
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        else if (PE.Carisma < 10)
                                        {
                                            PE.Carisma = PE.Carisma;
                                            PE.Nivel = PE.Nivel + 1;
                                            PersonajeBL.Modificar(PE);
                                            Entrod = false;
                                            EntroN = false;
                                            Entro = false;
                                        }
                                        
                                    }

                                }

                            }

                        }

                    }

                }

            }

        }

    }

}
