using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class Habilidad_EspecialControlador: Interfaces.Habilidad_EspecialInterface
    {
        public Habilidad_Especial H_E { get; set; }

        public Habilidad_Especial CrearHabilidadHespecial()
        {
            Habilidad_Especial HES = new Habilidad_Especial();
            Console.WriteLine("Ingrese los datos de su nueva Habilidad");
            Console.WriteLine();
            Console.Write("Nombre: ");
            HES.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Descripción: ");
            HES.Descripcion = Console.ReadLine();
            BusinessLogic.HabilidadEspecialBL.Agregar(HES);
            
            return H_E;
        }
        public void ModificarHabilidadEspecial()
        {
            Console.WriteLine("Elija de la Habilidad que desea modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarHabilidadesEspeciales();
            Console.WriteLine();            
            bool Entra = true;
            while (Entra)
            {
                Console.WriteLine();
                Console.Write("Ingrese Id de la Habilidad elegida: ");
                string Comando = Console.ReadLine();
                int IdH;
                bool result = Int32.TryParse(Comando, out IdH);
                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Habilidad_Especial HH = BusinessLogic.HabilidadEspecialBL.Obtener(IdH);
                    Console.WriteLine();
                    Console.WriteLine("Seleccione que desea modificar");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar el Nombre ingrese: 1");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar la Descripción ingrese: 2");
                    bool EntraH = true;
                    while (EntraH)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        string ComandoH = Console.ReadLine();
                        int Num;
                        bool resultH = Int32.TryParse(ComandoH, out Num);

                        if (Num != 1 && Num != 2 || resultH == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Error lo que ingreso no es un valor, o un tipo de valor correcto, intente de nuevo");
                            Console.WriteLine();
                        }
                        else if (Num == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Nuevo Nombre: ");
                            HH.Nombre = Console.ReadLine();
                            EntraH = false;
                        }
                        else if (Num == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Nueva Descripción: ");
                            HH.Descripcion = Console.ReadLine();
                            EntraH = false;
                        }
                        BusinessLogic.HabilidadEspecialBL.Modificar(HH);
                        Entra = false;
                    }

                }

            }
            Console.WriteLine();
        }
        public void ListarHabilidadesEspeciales()
        {
            foreach (Habilidad_Especial CH2 in BusinessLogic.HabilidadEspecialBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(CH2.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(CH2.Nombre);
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
        public void ListarHabilidadHespecialPorClase()
        {
            Console.WriteLine("Para ver la lista de Habilidades debe elegir primero una clase a la que pertenezcan de la lista a continuación");
            Console.WriteLine();
            foreach (Clase Clases in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Clases.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Clases.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
            }
            bool Entro = true;
            while (Entro)
            {
                Console.WriteLine();
                Console.Write("Ingrese el Id de la Clase elegida: ");
                string Comando = Console.ReadLine();
                int IdCLA;
                bool result = Int32.TryParse(Comando, out IdCLA);

                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor de Id correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Clase CLA = ClaseBL.Obtener(IdCLA);
                    Console.Write(CLA.Nombre);
                    Console.WriteLine(":");
                    foreach (Habilidad_Especial CH2 in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Clase_HE CH5 = BusinessLogic.Clase_HEBL.Obtener(CLA.Id, CH2.Id);
                        if (CH5 != null)
                        {
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(CH2.Id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(", Nombre : ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(CH2.Nombre);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        Entro = false;
                    }

                }

            }
  
        }
        public void EliminarHabilidadEspecial()
        {
            Console.WriteLine("Elija de la siguiente lista la Habilidad Especial que desea eliminar");
            Console.WriteLine();
            foreach (Habilidad_Especial HE in HabilidadEspecialBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(HE.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(HE.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            bool EntroH = true;
            while (EntroH)
            {
                Console.WriteLine();
                Console.Write("Ingrese Id de la Habilidad elegida: ");
                string Comando1 = Console.ReadLine();
                int Idh;
                bool result1 = Int32.TryParse(Comando1, out Idh);
                if (result1 == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor de Id correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Habilidad_Especial HESP = HabilidadEspecialBL.Obtener(Idh);

                    if (HabilidadEspecialBL.Listar().Count > 0)
                    {
                        foreach (Clase C in ClaseBL.Listar())
                        {
                            Clase_HE CHE = Clase_HEBL.Obtener(C.Id, HESP.Id);
                            if (CHE != null)
                            {
                                Clase_HEBL.Eliminar(C.Id, HESP.Id);
                            }

                        }
                        foreach (Personaje P in PersonajeBL.Listar())
                        {
                            Personaje_HE PHE = Personaje_HEBL.Obtener(P.Id, HESP.Id);
                            if (PHE != null)
                            {
                                Personaje_HEBL.Eliminar(P.Id, HESP.Id);
                            }

                        }
                        HabilidadEspecialBL.Eliminar(HESP.Id);
                    }
                    else if (HabilidadEspecialBL.Listar().Count == 0)
                    {
                        HabilidadEspecialBL.Eliminar(HESP.Id);
                    }
                    EntroH = false;
                }

            }
          
        }

    }

}
