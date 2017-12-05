using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class ClaseControlador
    {
        public Clase Clase { get; set; }
        public Habilidad_EspecialControlador HEControlador = new Habilidad_EspecialControlador();
 
        public Clase CrearClase()
        {
            Clase C = new Clase();
            Console.WriteLine("Ingrese los datos de su nueva Clase");
            Console.WriteLine();
            Console.Write("Nombre: ");
            C.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Descripción: ");
            C.Descripcion = Console.ReadLine();
            ClaseBL.Agregar(C);
            foreach(Clase CLASE in ClaseBL.Listar())
            {
                if(CLASE.Nombre == C.Nombre && CLASE.Descripcion == C.Descripcion)
                {
                    int IDN = CLASE.Id;
                    Clase CLA = ClaseBL.Obtener(IDN);

                    Console.WriteLine();
                    Console.WriteLine("Seleccione las Habilidades Especiales que desee que tenga la nueva Clase ingresando su Id");
                    Console.WriteLine();
                    HEControlador.ListarHabilidadesEspeciales();
                    Console.WriteLine();
                    Console.Write("Ingrese Id de la Habilidad elegida: ");
                    string comando = Console.ReadLine();
                    int IdC;
                    bool result = Int32.TryParse(comando, out IdC);
                    Habilidad_Especial H = HabilidadEspecialBL.Obtener(IdC);
                    bool EntraCLH = true;
                    while (EntraCLH)
                    {
                        if (H == null || result == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ingreso un Id de Habilidad inexistente en el sistema intente ingresar otro Id");
                            Console.WriteLine();
                        }
                        else if (H != null)
                        {
                            Clase_HEBL.Agregar(CLA, H);
                            Console.WriteLine();
                        }
                        bool Entra3 = true;
                        while (Entra3)
                        {
                            Console.WriteLine("Para agregar otra Habilidad ingrese: 1");
                            Console.WriteLine();
                            Console.WriteLine("Para crear nueva Habilidad y agregarla ingrese: 2");
                            Console.WriteLine();
                            Console.WriteLine("Para finalisar ingrese: 3");
                            Console.WriteLine();
                            Console.Write("Ingrese Comando: ");
                            string comandox = Console.ReadLine();
                            int com;
                            bool result3 = Int32.TryParse(comandox, out com);
         
                            if(com != 1 && com != 2 && com != 3 || result3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El comando ingresado no es correcto, intente de nuevo");
                                Console.WriteLine();
                            }
                            if (com == 1)
                            {
                                Console.WriteLine();
                                Console.Write("Ingrese Id de la Habilidad elegida: ");
                                string comando2 = Console.ReadLine();
                                int IdC2;
                                bool result2 = Int32.TryParse(comando2, out IdC2);
                                H = HabilidadEspecialBL.Obtener(IdC2);
                                Clase_HEBL.Agregar(CLA, H);
                                Console.WriteLine();
                            }
                            else if (com == 2)
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

                                foreach (Habilidad_Especial H4 in BusinessLogic.HabilidadEspecialBL.Listar())
                                {                
                                    if(H4.Nombre == HES.Nombre && H4.Descripcion == HES.Descripcion)
                                    {
                                        Clase_HEBL.Agregar(CLA, H4);
                                        Console.WriteLine();
                                    }

                                }

                            }
                            else if (com == 3)
                            {
                                EntraCLH = false;
                                Entra3 = false;
                            }

                        }
                       
                    }

                }         

            }
            return Clase;
        }
        public void ModificarClase()
        {
            Console.WriteLine("Elija de la Clase que desea modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarClases();
            Console.WriteLine();
            bool Entra = true;
            while (Entra)
            {
                Console.Write("Ingrese Id de la Clase elegida: ");
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
                    Clase CC = BusinessLogic.ClaseBL.Obtener(IdC);
                    Console.WriteLine();
                    Console.WriteLine("Seleccione que desea modificar");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar el Nombre ingrese: 1");
                    Console.WriteLine();
                    Console.WriteLine("Para modificar la Descripción  ingrese: 2");
                    Console.WriteLine();
                    Console.WriteLine("Para agregarle Habilidades  ingrese: 3");
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
                            CC.Nombre = Console.ReadLine();
                            EntraH = false;
                        }
                        else if (Num == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Nueva Descripción: ");
                            CC.Descripcion = Console.ReadLine();
                            EntraH = false;
                        }
                        else if (Num == 3)
                        {         
                            Console.WriteLine();
                            Console.WriteLine("Seleccione las Habilidades Especiales que desee que tenga la nueva Clase ingresando su Id");
                            Console.WriteLine();
                            foreach(Habilidad_Especial He in HabilidadEspecialBL.Listar())
                            {
                                Clase_HE Che = Clase_HEBL.Obtener(CC.Id, He.Id);
                                if(Che == null)
                                {
                                    Console.Write("Id: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(He.Id);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(", Nombre : ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(He.Nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            Console.WriteLine();
                            Console.Write("Ingrese Id de la Habilidad elegida: ");
                            string comando1 = Console.ReadLine();
                            int IdC1;
                            bool result1 = Int32.TryParse(comando1, out IdC1);
                            Habilidad_Especial H = HabilidadEspecialBL.Obtener(IdC1);
                            bool EntraCLH = true;
                            while (EntraCLH)
                            {
                                if (H == null || result1 == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Ingreso un Id de Habilidad inexistente en el sistema intente ingresar otro Id");
                                    Console.WriteLine();
                                }
                                else if (H != null)
                                {
                                    Clase_HEBL.Agregar(CC, H);
                                    Console.WriteLine();
                                }
                                bool Entra3 = true;
                                while (Entra3)
                                {
                                    Console.WriteLine("Para agregar otra Habilidad ingrese: 1");
                                    Console.WriteLine();
                                    Console.WriteLine("Para crear nueva Habilidad y agregarla ingrese: 2");
                                    Console.WriteLine();
                                    Console.WriteLine("Para finalizar ingrese: 3");
                                    Console.WriteLine();
                                    Console.Write("Ingrese Comando: ");
                                    string comandox = Console.ReadLine();
                                    int com;
                                    bool result3 = Int32.TryParse(comandox, out com);

                                    if (com != 1 && com != 2 && com != 3 || result3 == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("El comando ingresado no es correcto, intente de nuevo");
                                        Console.WriteLine();
                                    }
                                    if (com == 1)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Ingrese Id de la Habilidad elegida: ");
                                        string comando2 = Console.ReadLine();
                                        int IdC2;
                                        bool result2 = Int32.TryParse(comando2, out IdC2);
                                        H = HabilidadEspecialBL.Obtener(IdC2);
                                        Clase_HEBL.Agregar(CC, H);
                                        Console.WriteLine();
                                    }
                                    else if (com == 2)
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

                                        foreach (Habilidad_Especial H4 in BusinessLogic.HabilidadEspecialBL.Listar())
                                        {
                                            if (H4.Nombre == HES.Nombre && H4.Descripcion == HES.Descripcion)
                                            {
                                                Clase_HEBL.Agregar(CC, H4);
                                                Console.WriteLine();
                                            }

                                        }

                                    }
                                    else if (com == 3)
                                    {
                                        EntraCLH = false;
                                        Entra3 = false;
                                    }

                                }

                            }
                            EntraH = false;
                        }
                        BusinessLogic.ClaseBL.Modificar(CC);
                        Entra = false;
                    }

                }

            }

        }
        public void ListarClases()
        {
            foreach (Clase ClaseLI in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(ClaseLI.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(ClaseLI.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Descripción : ");
                Console.WriteLine(ClaseLI.Descripcion);
                Console.WriteLine();
            }
        }
        public void EliminarClase()
        {
            Console.WriteLine("Elija de la siguiente lista la Clase que desea eliminar");
            Console.WriteLine();
            Console.WriteLine();
            foreach (Clase ClaseLI in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(ClaseLI.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(ClaseLI.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Descripción : ");
                Console.WriteLine(ClaseLI.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            bool EntroH = true;
            while (EntroH)
            {            
                Console.Write("Ingrese Id de la Clase elegida: ");
                string Comando1 = Console.ReadLine();
                int IdC;
                bool result1 = Int32.TryParse(Comando1, out IdC);
                if (result1 == false || IdC == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ingreso un Id de Clase que no se puede eliminar o un Id inexistente en el sistema intente ingresar otro Id");
                    Console.WriteLine();
                }
                else
                {
                    Clase CLAS = ClaseBL.Obtener(IdC);

                    if(PersonajeBL.Listar().Count > 0)
                    {
                        foreach (Personaje Pe in PersonajeBL.Listar())
                        {
                            if (Pe.ClaseAtributo.Id == CLAS.Id)
                            {
                                int Idc = 10;
                                Pe.ClaseAtributo = ClaseBL.Obtener(Idc);
                                BusinessLogic.PersonajeBL.Modificar(Pe);
                            }
                        }
                    }
                    if (HabilidadEspecialBL.Listar().Count > 0)
                    {
                        foreach (Habilidad_Especial HESP in HabilidadEspecialBL.Listar())
                        {
                            Clase_HE CHE = Clase_HEBL.Obtener(CLAS.Id, HESP.Id);
                            if (CHE != null)
                            {
                                Clase_HEBL.Eliminar(CLAS.Id, HESP.Id);
                            }

                        }
                        ClaseBL.Eliminar(IdC);

                    }
                    else if (HabilidadEspecialBL.Listar().Count == 0)
                    {
                        ClaseBL.Eliminar(IdC);
                    }
                    EntroH = false;
                }

            }

        }

    }

}
