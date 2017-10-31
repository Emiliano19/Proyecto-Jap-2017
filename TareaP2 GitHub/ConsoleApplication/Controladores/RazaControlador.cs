using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class RazaControlador
    {
        public Personaje PersonajeV { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public ClaseControlador ClaseControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador { get; set; }
        public CaracteristicaControlador CarCont { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }
        public CaracteristicaControlador CaracteristicasControlador = new CaracteristicaControlador();


        public Raza CrearRaza()
        {
            Raza Raza = new Raza();
            Console.WriteLine("Ingrese los datos de su nueva Raza");
            Console.WriteLine();
            Console.Write("Nombre: ");
            Raza.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Descripció: ");
            Raza.Descripcion = Console.ReadLine();
            Console.WriteLine();
            bool Plusentra = true;
            while (Plusentra)
            {
                Console.Write("Valor Plus: ");
                int Valor = int.Parse(Console.ReadLine());
                if(Valor > 5 || Valor <= 0)
                {
                    Console.WriteLine("Error el Valor Plus no puede ser mayor a 5 o menor igual a 0, intente de nuevo");
                }
                if(Valor <= 5 && Valor > 0)
                {
                    Raza.ValorPlus = Valor;
                    Plusentra = false;
                }
                Console.WriteLine();

            }
            Console.WriteLine("Elija de la siguiente lista la caracteristica asociada a la nueva Raza");
            Console.WriteLine();
            foreach (Caracteristica CaracteristicaLI in BusinessLogic.CaracteristicaBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(CaracteristicaLI.Id);
                Console.Write(", Nombre : ");
                Console.WriteLine(CaracteristicaLI.Nombre);
                Console.WriteLine();
            }
            Console.Write("Ingrese el Id de la Caracteristica elegida: ");
            int IdCar = int.Parse(Console.ReadLine());
            Caracteristica C = CaracteristicaBL.Obtener(IdCar);
            Raza.Caract_VarRazaAtributo = C;
            int idRazaGenerada = BusinessLogic.RazaBL.Agregar(Raza);
            Console.WriteLine();
 
            return Raza;
        }
        public void ModificarRaza()
        {
            Console.WriteLine("Elija de la Raza que desa modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarRazas();
            Console.WriteLine();
            bool Entra = true;
            while (Entra)
            {
                Console.Write("Ingrese Id de la Raza elegida: ");
                string Comando = Console.ReadLine();
                int IdR;
                bool result = Int32.TryParse(Comando, out IdR);
                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Raza RR = BusinessLogic.RazaBL.Obtener(IdR);
                    Console.WriteLine();
                    Console.WriteLine("Selecione que desea modificar");
                    Console.WriteLine();
                    Console.WriteLine("Para odificar el Nombre ingrese: 1");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar la Descripción  ingrese: 2");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar la Caracteristica  ingrese: 3");
                    bool EntraH = true;
                    while (EntraH)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        string ComandoH = Console.ReadLine();
                        int Num;
                        bool resultH = Int32.TryParse(ComandoH, out Num);

                        if (Num != 1 && Num != 2 && Num != 3 || resultH == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Nuevo Nombre: ");
                            RR.Nombre = Console.ReadLine();
                            EntraH = false;
                        }
                        else if (Num == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Nueva Descripción: ");
                            RR.Descripcion = Console.ReadLine();
                            EntraH = false;
                        }
                        else if (Num == 3)
                        {
                            bool Entro = true;
                            while (Entro)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Elija de la siguiente lista la nueva caracteristica asociada a su Raza");
                                Console.WriteLine();
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
                                Console.WriteLine();
                                Console.WriteLine("Si elijio una de la lista ingrese: 1");
                                Console.WriteLine();
                                Console.WriteLine("Si quiere crear una nueva Característica ingrese: 2");
                                Console.WriteLine();
                                Console.Write("Ingrese comando: ");
                                string Comando23 = Console.ReadLine();
                                int Num23;
                                bool result23 = Int32.TryParse(Comando23, out Num23);

                                if (Num23 != 1 && Num23 != 2 || result23 == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                                    Console.WriteLine();
                                }
                                else if (Num23 == 1)
                                {
                                    bool Entro24 = true;
                                    while (Entro24)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Ingrese el Id de la Caracteristica elegida: ");
                                        string ComandoZ = Console.ReadLine();
                                        int IdZ;
                                        bool resultZ = Int32.TryParse(ComandoZ, out IdZ);
                                        if (resultZ == false)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                                        }
                                        else
                                        {
                                            Caracteristica CaC = CaracteristicaBL.Obtener(IdZ);
                                            BusinessLogic.RazaBL.Modificar(RR, CaC.Id);
                                            Entro24 = false;
                                            Entro = false;
                                            EntraH = false;
                                        }

                                    }

                                }
                                else if (Num23 == 2)
                                {
                                    Console.WriteLine();
                                    Caracteristica C2 = CaracteristicasControlador.CrearCaracteristica();
                                    int IdC = RazaBL.Listar().Max(X => X.Id);
                                    BusinessLogic.RazaBL.Modificar(RR, IdC);
                                    Entro = false;
                                    EntraH = false;

                                }

                            }

                        }
                        Entra = false;
                    }

                }

            }

        }
        public void ListarRazas()
        {
            foreach(Raza RazaLI in BusinessLogic.RazaBL.Listar())
            {
                Caracteristica CARAC = CaracteristicaBL.Obtener(RazaLI.Caract_VarRazaAtributo.Id);
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(RazaLI.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(RazaLI.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Característica: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CARAC.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Descripción : ");
                Console.WriteLine(RazaLI.Descripcion);
                Console.WriteLine();
            }

        }
        public void EliminarRaza()
        {
            Console.WriteLine("Elija la Raza que desea eliminar de la siguiente lista");
            Console.WriteLine();
            ListarRazas();
            bool entra = true;
            while (entra)
            {
                Console.Write("Ingrese el Id de la Raza que desea Eliminar: ");
                string comando = Console.ReadLine();
                int idr;
                bool result = Int32.TryParse(comando, out idr);
                Raza R = RazaBL.Obtener(idr);

                if (R == null || R.Id == 10 || result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ingreso un Id de Raza que no se puede eliminar o un Id inexistente en el sistema intente ingresar otro Id");
                    Console.WriteLine();
 
                }
                else if(R != null && R.Id != 10)
                {
                    foreach (Personaje Pe in PersonajeBL.Listar())
                    {
                        if (Pe.RazaAtributo.Id == R.Id)
                        {
                            int Idr = 10;
                            Pe.RazaAtributo = RazaBL.Obtener(Idr);
                            int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(Pe);
                            BusinessLogic.PersonajeBL.Modificar(Pe);

                        }
                    }
                    RazaBL.Eliminar(R);
                    entra = false;
                }
            }
          
            Console.WriteLine();
            Console.WriteLine("Su Raza a sido eliminada con exito para serceorarse valla a ListarRazas");
            Console.WriteLine();

        }

    }

}
