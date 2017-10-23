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


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


        public void SubirNivel()
        {
            bool EntraNivel = true;
            while (EntraNivel)
            {
                Console.WriteLine("Seleccione el Personaje al que le quiere subir de Nivel de la siguiente lista");
                Console.WriteLine();
                foreach (Personaje PeriList in Personaje_List)
                {
                    Console.Write(PeriList.Nombre);
                    Console.Write(" -> Id: ");
                    Console.WriteLine(PeriList.Id);
                    Console.WriteLine();
                }
                Console.Write("Ingrese el Nombre del Personaje elejido: ");
                string PersoElegido = Console.ReadLine();
                Console.WriteLine();
                foreach (Personaje PerNivel in Personaje_List)
                {
                    if (PersoElegido == PerNivel.Nombre)
                    {
                        Console.WriteLine("Como su Personaje subira de nivel puede adquirir una Habilidad Especial a eleccion de la siguiente lista");
                        Console.WriteLine();
                        foreach (Habilidad_Especial HE in PerNivel.ClaseAtributo.HE_AtributoColeccion)
                        {
                            Console.Write(HE.Nombre);
                            Console.Write(" -> Descripcion: ");
                            Console.WriteLine(HE.Descripcion);
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese nombre de la habilidad elegida: ");
                        string HABELEG = Console.ReadLine();
                        foreach (Habilidad_Especial HE in PerNivel.ClaseAtributo.HE_AtributoColeccion)
                        {
                            if (HABELEG == HE.Nombre)
                            {
                                PerNivel.H_EAtributoColeccion.Add(HE);
                            }

                        }
                        if (PerNivel.Nivel % 2 == 0)
                        {
                            PerNivel.Nivel = PerNivel.Nivel + 1;
                            EntraNivel = false;
                            break;
                        }
                        else if (PerNivel.Nivel % 2 != 0 && PerNivel.Nivel != 1)
                        {
                            Console.WriteLine();
                            bool EntraGeneral = true;
                            while (EntraGeneral)
                            {
                                Console.WriteLine("Elija de la siguiente lista la Caracteristica a la que desea subir un punto de valor plus");
                                Console.WriteLine();
                                foreach (Personaje_Caracteristica CarEleshi in PerNivel.C_VAtributoColeccion)
                                {
                                    Console.Write(CarEleshi.CaracteristicaV.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarEleshi.valor);
                                }
                                Console.WriteLine();
                                Console.Write("Escriba el Nombre de la que elijio: ");
                                string ComandoCL3 = Console.ReadLine();
                                bool Entra3 = true;
                                int Contador3 = 0;
                                while (Entra3)
                                {
                                    foreach (Personaje_Caracteristica CARVARIA in PerNivel.C_VAtributoColeccion)
                                    {
                                        if (CARVARIA.CaracteristicaV.Nombre == ComandoCL3)
                                        {
                                            Contador3 = Contador3 + 1;
                                            CARVARIA.valor = CARVARIA.valor + 1;
                                            Entra3 = false;
                                            EntraGeneral = false;
                                            break;
                                        }

                                    }
                                    if (Contador3 == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Error la Caracteristica que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                        Console.WriteLine();
                                        Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                        ComandoCL3 = Console.ReadLine();
                                    }

                                }
                                PerNivel.Nivel = PerNivel.Nivel + 1;
                                break;

                            }
                            EntraNivel = false;
                            Console.WriteLine();
                        }
                        break;

                    }

                }
                break;

            }
            Console.WriteLine("Su personaje a subido con exito de Nivel");
            Console.WriteLine();

        }

    }

}
