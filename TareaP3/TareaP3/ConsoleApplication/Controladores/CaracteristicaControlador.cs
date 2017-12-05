using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class CaracteristicaControlador
    {  
        public Caracteristica Caracteristica { get; set; }

        public Caracteristica CrearCaracteristica()
        {
            Caracteristica C = new Caracteristica();
            Console.WriteLine("Ingrese los datos de su nueva Característica");
            Console.WriteLine();
            Console.Write("Nombre: ");
            C.Nombre = Console.ReadLine();
            Console.WriteLine();
            int valor = 1;
            BusinessLogic.CaracteristicaBL.Agregar(C);
            Personaje_Caracteristica Pc = new Personaje_Caracteristica();
            int IdCMax = CaracteristicaBL.Listar().Max(x => x.Id);
            foreach (Personaje P in BusinessLogic.PersonajeBL.Listar())
            {
                BusinessLogic.Personaje_CaracteristicaBL.Agregar(P.Id, IdCMax, valor);
            }            

            return Caracteristica;
        }
        public void ModificarCaracteristica()
        {
            Console.WriteLine("Elija de la Característica que desea modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarCaracteristicas();
            Console.WriteLine();
            bool Entra1 = true;
            while (Entra1)
            {
                Console.WriteLine();
                Console.Write("Ingrese el Id de la Característica elegida: ");
                string Comando = Console.ReadLine();
                int IdC;
                bool result = Int32.TryParse(Comando, out IdC);
                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Caracteristica Car = CaracteristicaBL.Obtener(IdC);
                    Console.WriteLine("En esta Instancia solo se puede modificar el Nombre de la Característica pues el Valor cambia para cada Personaje");
                    Console.WriteLine();
                    Console.Write("Nuevo Nombre: ");
                    Car.Nombre = Console.ReadLine();
                    CaracteristicaBL.Modificar(Car);
                    Entra1 = false;
                }

            }          

        }
        public void ListarCaracteristicas()
        {
            foreach (Caracteristica CaracteristicaLI in BusinessLogic.CaracteristicaBL.Listar())
            {
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CaracteristicaLI.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(CaracteristicaLI.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void EliminarCaracteristica()
        {
            Console.WriteLine("Lista de las Características Variables existentes en el sistema");
            Console.WriteLine();
            ListarCaracteristicas();
            Console.WriteLine();
            Console.Write("Ingrese el Id de la Característica elegida: ");
            string Comando = Console.ReadLine();
            int IdC;
            bool result = Int32.TryParse(Comando, out IdC);
            if (result == false)
            {
                Console.WriteLine();
                Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                Console.WriteLine();
            }
            else
            {
                if(PersonajeBL.Listar().Count > 0)
                {
                    foreach (Personaje P in PersonajeBL.Listar())
                    {
                        Personaje_Caracteristica PC = Personaje_CaracteristicaBL.Obtener(P.Id, IdC);
                        if(PC != null)
                        {
                            Personaje_CaracteristicaBL.Eliminar(P.Id, IdC);
                        }
                        
                    }
                    
                }
                Caracteristica CA = CaracteristicaBL.Obtener(IdC);
                if(RazaBL.Listar().Count > 0)
                {
                    foreach (Raza R in RazaBL.Listar())
                    {
                        if (R.Caract_VarRazaAtributo.Id == CA.Id)
                        {
                            int Idc = 10;
                            Raza RR = RazaBL.Obtener(R.Id);
                            Caracteristica CaC = CaracteristicaBL.Obtener(Idc);
                            BusinessLogic.RazaBL.Modificar(RR, CaC.Id);
                           
                        }

                    }
                    
                }
                CaracteristicaBL.Eliminar(IdC);
            }

        }

    }

}
