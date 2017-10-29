using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class PersonajeControlador
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public RazaControlador RazaControlador = new RazaControlador();
        public ClaseControlador ClaseControlador = new ClaseControlador();
        public Habilidad_EspecialControlador HEControlador = new Habilidad_EspecialControlador();
        public CaracteristicaControlador CaracteristicasControlador = new CaracteristicaControlador();
        public SubirdeNivel SubirdeNivelControlador = new SubirdeNivel();


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();

        public Personaje CrearPersonaje()
        {
            Personaje PersonajeX = new Personaje();
            Console.WriteLine("Ingrese los datos de su nuevo Personaje");
            Console.WriteLine();
            Console.Write("Nombre: ");
            PersonajeX.Nombre = Console.ReadLine();
            Console.WriteLine();
            bool Nivelentra = true;
            while (Nivelentra)
            {
                Console.Write("Nivel: ");
                string CNivel = Console.ReadLine();
                int Nivel;
                bool result = Int32.TryParse(CNivel, out Nivel);
                Console.WriteLine();

                if(result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if(result == true)
                {
                    if(Nivel > 10 || Nivel <= 0)
                    {
                        Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if(Nivel > 0 && Nivel <= 10)
                    {
                        PersonajeX.Nivel = Nivel;
                        Nivelentra = false;
                    }
                    
                }
              
            }
            bool Fuerzaentra = true;
            while (Fuerzaentra)
            {
                Console.Write("Fuerza: ");
                string CFuerza = Console.ReadLine();
                int Fuerza;
                bool result = Int32.TryParse(CFuerza, out Fuerza);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Fuerza > 10 || Fuerza <= 0)
                    {
                        Console.WriteLine("Error la Fuerza no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Fuerza > 0 && Fuerza <= 10)
                    {
                        PersonajeX.Fuerza = Fuerza;
                        Fuerzaentra = false;
                    }

                }

            }
            bool Destrezaentra = true;
            while (Destrezaentra)
            {
                Console.Write("Destreza: ");
                string CDestreza = Console.ReadLine();
                int Destreza;
                bool result = Int32.TryParse(CDestreza, out Destreza);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Destreza > 10 || Destreza <= 0)
                    {
                        Console.WriteLine("Error la Destreza no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Destreza > 0 && Destreza <= 10)
                    {
                        PersonajeX.Destreza = Destreza;
                        Destrezaentra = false;
                    }

                }

            }
            bool Constitucionentra = true;
            while (Constitucionentra)
            {
                Console.Write("Constitucion: ");
                string CConstitucion = Console.ReadLine();
                int Constitucion;
                bool result = Int32.TryParse(CConstitucion, out Constitucion);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Constitucion > 10 || Constitucion <= 0)
                    {
                        Console.WriteLine("Error la Constitución no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Constitucion > 0 && Constitucion <= 10)
                    {
                        PersonajeX.Constitucion = Constitucion;
                        Constitucionentra = false;
                    }

                }

            }
            bool Inteligenciaentra = true;
            while (Inteligenciaentra)
            {
                Console.Write("Inteligencia: ");
                string CInteligencia = Console.ReadLine();
                int Inteligencia;
                bool result = Int32.TryParse(CInteligencia, out Inteligencia);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Inteligencia > 10 || Inteligencia <= 0)
                    {
                        Console.WriteLine("Error la Inteligencia no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Inteligencia > 0 && Inteligencia <= 10)
                    {
                        PersonajeX.Inteligencia = Inteligencia;
                        Inteligenciaentra = false;
                    }

                }

            }
            bool Sabiduriaentra = true;
            while (Sabiduriaentra)
            {
                Console.Write("Sabiduria: ");
                string CSabiduria = Console.ReadLine();
                int Sabiduria;
                bool result = Int32.TryParse(CSabiduria, out Sabiduria);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Sabiduria > 10 || Sabiduria <= 0)
                    {
                        Console.WriteLine("Error la Sabiduria no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Sabiduria > 0 && Sabiduria <= 10)
                    {
                        PersonajeX.Sabiduria = Sabiduria;
                        Sabiduriaentra = false;
                    }

                }

            }
            bool Carismaentra = true;
            while (Carismaentra)
            {
                Console.Write("Carisma: ");
                string CCarisma = Console.ReadLine();
                int Carisma;
                bool result = Int32.TryParse(CCarisma, out Carisma);
                Console.WriteLine();

                if (result == false)
                {
                    Console.WriteLine("Error lo que a ingresado no es un valor de tipo entero, intente de nuevo");
                    Console.WriteLine();
                }
                else if (result == true)
                {
                    if (Carisma > 10 || Carisma <= 0)
                    {
                        Console.WriteLine("Error el Carisma no puede ser menor o igual a 0 ni mayor a 10, intente de nuevo");
                        Console.WriteLine();
                    }
                    else if (Carisma > 0 && Carisma <= 10)
                    {
                        PersonajeX.Carisma = Carisma;
                        Carismaentra = false;
                    }

                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Razas Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            foreach (Raza RazaLI in BusinessLogic.RazaBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(RazaLI.Id);
                Console.Write(", Nombre : ");
                Console.Write(RazaLI.Nombre);
                Console.Write(", Descripción : ");
                Console.WriteLine(RazaLI.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine("Si Elige una Raza de la lista Ingrese: 1");
            Console.WriteLine();
            Console.WriteLine("Si desean crear una nueva Raza Ingrese: 2");
            Console.WriteLine();
            bool EntraRa = true;
            while (EntraRa)
            {
                Console.Write("Ingrese Comando: ");
                string comando = Console.ReadLine();
                int ComandoRA;
                bool result = Int32.TryParse(comando, out ComandoRA);

                if (ComandoRA != 1 && ComandoRA != 2 || result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Comando erroneo intente de nuevo");
                    Console.WriteLine();
                }
                else if (ComandoRA == 1)
                {
                    Console.WriteLine();
                    bool EntraRa2 = true;
                    while (EntraRa2)
                    {
                        Console.Write("Escriba el Id de la Raza elejida: ");
                        string comando2 = Console.ReadLine();
                        int ComandoRA2;
                        bool result2 = Int32.TryParse(comando2, out ComandoRA2);
                        Raza R = RazaBL.Obtener(ComandoRA);

                        if (R == null || result2 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ingreso un Id de Raza que no se puede eliminar o un Id inexistente en el sistema intente ingresar otro Id");
                            Console.WriteLine();

                        }
                        else if(R != null)
                        {
                            PersonajeX.RazaAtributo = R;
                            EntraRa = false;
                            EntraRa2 = false;
                        }

                    }             

                }
                else if (ComandoRA == 2)
                {
                    Console.WriteLine();
                    Raza RA = RazaControlador.CrearRaza();
                    PersonajeX.RazaAtributo = RA;
                    EntraRa = false;
                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Clases Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            foreach (Clase ClaseLI in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(ClaseLI.Id);
                Console.Write(", Nombre : ");
                Console.Write(ClaseLI.Nombre);
                Console.Write(", Descripción : ");
                Console.WriteLine(ClaseLI.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine("Si Elige una Clase de la lista Ingrese: 1");
            Console.WriteLine();
            Console.WriteLine("Si desean crear una nueva Clase Ingrese: 2");
            Console.WriteLine();
            bool EntraCLA = true;
            while (EntraCLA)
            {
                Console.Write("Ingrese Comando: ");
                string comando = Console.ReadLine();
                int ComandoCLA;
                bool result = Int32.TryParse(comando, out ComandoCLA);

                if (ComandoCLA != 1 && ComandoCLA != 2 || result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Comando erroneo intente de nuevo");
                    Console.WriteLine();
                }
                else if (ComandoCLA == 1)
                {
                    Console.WriteLine();
                    bool EntraCLA2 = true;
                    while (EntraCLA2)
                    {
                        Console.Write("Escriba el Id de la Clase elejida: ");
                        string comando2 = Console.ReadLine();
                        int idc;
                        bool result2 = Int32.TryParse(comando2, out idc);
                        Clase C = ClaseBL.Obtener(idc);

                        if (C == null || result2 == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ingreso un Id de Clase que no se puede eliminar o un Id inexistente en el sistema intente ingresar otro Id");
                            Console.WriteLine();

                        }
                        else if (C != null)
                        {
                            PersonajeX.ClaseAtributo = C;
                            EntraCLA = false;
                            EntraCLA2 = false;
                        }

                    }

                }
                else if (ComandoCLA == 2)
                {
                    Console.WriteLine();
                    Clase CL = ClaseControlador.CrearClase();
                    PersonajeX.ClaseAtributo = CL;
                    EntraCLA = false;
                }

            }
            BusinessLogic.PersonajeBL.Agregar(PersonajeX);
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Caracteristicas Variables Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            CaracteristicasControlador.ListarCaracteristicas();
            Console.WriteLine("Todas se agregaran al Personaje con los valores que usted le debe cargar a Continuacion");
            Console.WriteLine();
            Personaje_Caracteristica PeC = new Personaje_Caracteristica();
            foreach (Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
            {             
                PeC.CaracteristicaV = C;
                Console.Write(C.Nombre);
                Console.Write(" => Valor: ");
                PeC.valor = int.Parse(Console.ReadLine());
                foreach(Personaje P in PersonajeBL.Listar())
                {
                    int con = 0;
                    int Id1 = 0;
                    int Id2 = P.Id;
                    int IdMax = Math.Max(Id1, Id2);
                    Id1 = Id2;
                    con = con + 1;
                    if(con == PersonajeBL.Listar().Count)
                    {
                        Personaje PER = PersonajeBL.Obtener(IdMax);
                        BusinessLogic.Personaje_CaracteristicaBL.Agregar(PER, C, PeC.valor);
                        
                    }

                }
                Console.WriteLine();
               
            }
            Console.WriteLine();
            Console.WriteLine("Si desea crear una nueva Caracteristica y agregarla ingrese: 1");
            Console.WriteLine();
            Console.WriteLine("Si desea finalisar el proceso ingrese: 2");
            Console.WriteLine();
            bool Entra = true;
            while (Entra)
            {
                Console.Write("Ingrese comando: ");
                string comando = Console.ReadLine();
                int com;
                bool result = Int32.TryParse(comando, out com);

                if (com != 1 && com != 2)
                {
                    Console.WriteLine("Comando erroneo intente de nuevo");
                    Console.WriteLine();
                   
                }
                else if (com == 1)
                {
                    Caracteristica C1 = CaracteristicasControlador.CrearCaracteristica();
                    Console.WriteLine();
                    Console.WriteLine("Si desea crear una nueva Caracteristica y agregarla ingrese: 1");
                    Console.WriteLine();
                    Console.WriteLine("Si desea finalisar el proceso ingrese: 2");
                    Console.WriteLine();
                }
                else if (com == 2)
                {
                    if (CaracteristicaBL.Listar().Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("No existen Caracteristicas en el Sistema debe crear alguna nueva");
                        Console.WriteLine();
                        Console.WriteLine("Para crear nueva caracteristica ingrese: 1");
                        Console.WriteLine();
                    }
                    else if (CaracteristicaBL.Listar().Count > 0)
                    {
                        Entra = false;
                    }

                }

            }
            
            foreach (Personaje P in PersonajeBL.Listar())
            {
                int con = 0;
                int Id1 = 0;
                int Id2 = P.Id;
                int IdMax = Math.Max(Id1, Id2);
                Id1 = Id2;
                con = con + 1;             
                if (con == PersonajeBL.Listar().Count)
                {
                    int Plus = P.RazaAtributo.ValorPlus;
                    int IdCR = P.RazaAtributo.Caract_VarRazaAtributo.Id;
                    int IdP = P.Id;
                    Personaje_Caracteristica PCA = Personaje_CaracteristicaBL.Obtener(IdMax, IdCR);
                    int suma = PCA.valor + Plus;
                    if(suma <= 15)
                    {
                        Personaje_CaracteristicaBL.Modificar(IdMax, IdCR, Plus);
                        Console.WriteLine();
                        break;
                    }
                }
            }

            return PersonajeV;

        }
        public void ModificarPersonaje()
        {
            Console.WriteLine("Elija el Personaje que desa modificar de la siguiente lista");
            Console.WriteLine();
            foreach(Personaje Per in BusinessLogic.PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.Write(Per.Id);
                Console.Write(" -> ");
                Console.WriteLine(Per.Nombre);
                Console.WriteLine();
            }
            Console.Write("Ingrese el Id del Personaje que desea modificar: ");
            int ComandoId = int.Parse(Console.ReadLine());
            int id = Convert.ToInt32(ComandoId);
            Personaje P = PersonajeBL.Obtener(id);
            Console.WriteLine();
                    
            bool Entra1 = true;
            while (Entra1)
            {
                Console.WriteLine();
                Console.WriteLine("Selecione que desea modificar ingresando el numero de la opción: ");
                Console.WriteLine();
                Console.WriteLine(" 1 - Nombre");
                Console.WriteLine(" 2 - Nivel");
                Console.WriteLine(" 3 - Fuerza");
                Console.WriteLine(" 4 - Destreza");
                Console.WriteLine(" 5 - Constitucion");
                Console.WriteLine(" 6 - Inteligencia");
                Console.WriteLine(" 7 - Sabiduria");
                Console.WriteLine(" 8 - Carisma");
                Console.WriteLine(" 9 - Raza");
                Console.WriteLine("10 - Clase");
                Console.WriteLine("11 - Caracteristica");
                Console.WriteLine("12 - Modificar Todo");
                Console.WriteLine();
                Console.Write("Ingrese el comando elegido: ");
                int ComandoCL2 = int.Parse(Console.ReadLine());
                bool Entra = true;
                Console.WriteLine();
                while (Entra)
                {

                    if (ComandoCL2 != 1 && ComandoCL2 != 2 && ComandoCL2 != 3 && ComandoCL2 != 4 && ComandoCL2 != 5 && ComandoCL2 != 6 && ComandoCL2 != 7 && ComandoCL2 != 8
                        && ComandoCL2 != 9 && ComandoCL2 != 10 && ComandoCL2 != 11 && ComandoCL2 != 12)
                    {
                        Console.WriteLine("Comando Erroneo intente denuevo");
                        ComandoCL2 = int.Parse(Console.ReadLine());
                    }
                    else if (ComandoCL2 == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo Nombre del Personaje: ");
                        string NuevoNombre = Console.ReadLine();
                        Console.WriteLine();
                        P.Nombre = NuevoNombre;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor del Nivel para el Personaje: ");
                        int NuevoNivel = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Nivel = NuevoNivel;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                       
                        Entra = false;
                    }
                    else if (ComandoCL2 == 3)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Fuerza para el Personaje: ");
                        int NuevaFuerza = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Fuerza = NuevaFuerza;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 4)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Destreza para el Personaje: ");
                        int NuevaDestreza = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Destreza = NuevaDestreza;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 5)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Constitución para el Personaje: ");
                        int NuevaConstitucion = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Constitucion = NuevaConstitucion;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 6)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Inteligencia para el Personaje: ");
                        int NuevaInteligencia = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Inteligencia = NuevaInteligencia;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 7)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Sabiduria para el Personaje: ");
                        int NuevaSabiduria = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Sabiduria = NuevaSabiduria;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 8)
                    {
                        Console.WriteLine();
                        Console.Write("Ingrese el nuevo valor de Carisma para el Personaje: ");
                        int NuevoCarisma = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Carisma = NuevoCarisma;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Elija la nueva Raza de su Personaje de la siguiente lista");
                        Console.WriteLine();
                        foreach(Raza Ra in BusinessLogic.RazaBL.Listar())
                        {
                            Console.Write("Id: ");
                            Console.Write(Ra.Id);
                            Console.Write(" -> ");
                            Console.WriteLine(Ra.Nombre);
                            Console.WriteLine();
                        }
                        Console.Write("Escriba el Id de la Raza elegida: ");
                        int idr = int.Parse(Console.ReadLine());
                        P.RazaAtributo = RazaBL.Obtener(idr);
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Elija la nueva Clase de su Personaje de la siguiente lista");
                        Console.WriteLine();
                        ClaseControlador.ListarClases();
                        Console.Write("Escriba el Id de la Clase elegida: ");
                        int idc = int.Parse(Console.ReadLine());
                        P.RazaAtributo = RazaBL.Obtener(idc);
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        
                        Entra = false;
                    }
                    else if (ComandoCL2 == 11)
                     {
                         Console.WriteLine();
                         bool EntraGeneral = true;
                        while (EntraGeneral)
                        {
                            Console.WriteLine("Elija la Caracteristica que desea modificar de la siguiente lista");
                            Console.WriteLine();
                            //Aca tengo que llamar a la coleccion de caracteristicas de mi personaje
                            foreach (Personaje_Caracteristica C in BusinessLogic.Personaje_CaracteristicaBL.Listar())
                            {
                                Console.Write("Id = ");
                                Console.Write(C.CaracteristicaV.Id);
                                Caracteristica CA = BusinessLogic.CaracteristicaBL.Obtener(C.CaracteristicaV.Id);
                                Console.Write(", Nombre : ");
                                Console.Write(CA.Nombre);
                                Console.Write(", Valor : ");
                                Console.WriteLine(C.valor);
                                Console.WriteLine();
                            }
                            Console.Write("Ingrese Id de la caracteristica elegida: ");
                            string comando = Console.ReadLine();
                            int IdC;
                            bool result = Int32.TryParse(comando, out IdC);
                            bool Entra3 = true;
                            bool encontro = false;
                            while (Entra3)
                            {
                                Caracteristica PCC = CaracteristicaBL.Obtener(IdC);

                                if (PCC != null)
                                {
                                    Personaje_Caracteristica PCA = BusinessLogic.Personaje_CaracteristicaBL.Obtener(P.Id, PCC.Id);

                                    if (PCA != null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("En esta instancia solo puede modificar el valor de la Caracteristica para este Presonaje");
                                        Console.WriteLine();
                                        Console.WriteLine("Si desea Modificar el nombre valla al Procedimiento modificar Caracteristica, y el nombre cambiara para cada Personaje");
                                        Console.WriteLine();
                                        Console.Write("Escriba el nuevo valor de la Caracteristica: ");
                                        string comando1 = Console.ReadLine();
                                        int Valor;
                                        bool result1 = Int32.TryParse(comando1, out Valor);
                                        BusinessLogic.Personaje_CaracteristicaBL.Modificar(P.Id, PCC.Id, PCA.valor);
                                        encontro = !encontro;
                                        Entra3 = false;
                                        EntraGeneral = false;
                                        Entra = false;
                                        break;
                                    }
                                if (encontro == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Error la Caracteristica que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                    Console.WriteLine();
                                    Entra3 = false;
                                }
                            }



                        }
                               /*  Console.WriteLine();
                               Console.WriteLine("Si desea modificar el valor de otra de las caracteristicas ingrese SI de lo contrario ingrese NO");
                               Console.WriteLine();
                               string Eleccion = Console.ReadLine();
                              cif (Eleccion == "SI")
                              {
                                  Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                  ComandoCL3 = Console.ReadLine();
                                }
                                else if (Eleccion == "NO")
                                {
                                 EntraGeneral = false;
                                   Entra = false;
                                   }*/
                        }
                         /*Console.WriteLine();
                         foreach (Personaje_Caracteristica CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                         {
                             Console.Write(CarVarPerso.CaracteristicaV.Nombre);
                             Console.Write(" -> Valor: ");
                             Console.WriteLine(CarVarPerso.valor);
                         }*/

                    }
                   /*  else if (ComandoCL2 == 12)
                     {
                         Console.WriteLine();
                         PersonajeModi.Nombre = null;
                         Console.Write("Escriba el nuevo Nombre del Personaje: ");
                         PersonajeModi.Nombre = Console.ReadLine();
                         Console.WriteLine();
                         PersonajeModi.Nivel = 0;
                         Console.Write("Escriba el nuevo valor del Nilve: ");
                         PersonajeModi.Nivel = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Fuerza = 0;
                         Console.Write("Escriba el nuevo valor de la Fuerza: ");
                         PersonajeModi.Fuerza = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Destreza = 0;
                         Console.Write("Escriba el nuevo valor de la Destreza: ");
                         PersonajeModi.Destreza = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Constitucion = 0;
                         Console.Write("Escriba el nuevo valor de la Constitucion: ");
                         PersonajeModi.Constitucion = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Inteligencia = 0;
                         Console.Write("Escriba el nuevo valor de la Inteligencia: ");
                         PersonajeModi.Inteligencia = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Sabiduria = 0;
                         Console.Write("Escriba el nuevo valor de la Sabiduria: ");
                         PersonajeModi.Sabiduria = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.Carisma = 0;
                         Console.Write("Escriba el nuevo valor del Carisma: ");
                         PersonajeModi.Carisma = int.Parse(Console.ReadLine());
                         Console.WriteLine();
                         PersonajeModi.RazaAtributo = null;
                         Console.WriteLine("Escoja la nueva Raza para su Personaje de la siguiente lista");
                         Console.WriteLine();
                         foreach (Raza Razas in Raza_List)
                         {
                             Console.Write("{0}", Razas.Nombre);
                             Console.Write(" -> Descripcion: ");
                             Console.WriteLine(Razas.Descripcion);
                             Console.WriteLine();
                         }
                         Console.WriteLine();
                         Console.Write("Escriba el Nombre de la Raza elegida: ");
                         string ComandoEleccion = Console.ReadLine();
                         foreach (Raza RazaElegida in Raza_List)
                         {
                             if (ComandoEleccion == RazaElegida.Nombre)
                             {
                                 PersonajeModi.RazaAtributo = RazaElegida;
                             }
                         }
                         Console.WriteLine();
                         PersonajeModi.ClaseAtributo = null;
                         Console.WriteLine("Escoja la nueva Clase para su Personaje de la siguiente lista");
                         Console.WriteLine();
                         foreach (Clase Clases in Clase_List)
                         {
                             Console.Write("{0}", Clases.Nombre);
                             Console.Write(" -> Descripcion: ");
                             Console.WriteLine(Clases.Descripcion);
                             Console.WriteLine();
                         }
                         Console.WriteLine();
                         Console.Write("Escriba el Nombre de la Clase elegida: ");
                         string ComandoElec = Console.ReadLine();
                         foreach (Clase ClaseElegida in Clase_List)
                         {
                             if (ComandoElec == ClaseElegida.Nombre)
                             {
                                 PersonajeModi.ClaseAtributo = ClaseElegida;
                             }
                         }
                         Entra = false;
                         Console.WriteLine();
                         Console.WriteLine("Caracteristicas Existentes en la coleccion de caracteristicas del actual Personaje");
                         Console.WriteLine();
                         foreach (Personaje_Caracteristica CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                         {
                             Console.Write(CarVarPerso.CaracteristicaV.Nombre);
                             Console.Write(" -> Valor: ");
                             Console.WriteLine(CarVarPerso.valor);

                         }
                         Console.WriteLine();
                         Console.WriteLine("Caracteristicas Existentes en la coleccion de caracteristicas del actual Personaje");
                         Console.WriteLine();
                         foreach (Personaje_Caracteristica CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                         {
                             Console.Write(CarVarPerso.CaracteristicaV.Nombre);
                             Console.Write(" -> Valor: ");
                             Console.WriteLine(CarVarPerso.valor);

                         }
                         Console.WriteLine();
                         bool EntraGeneral = true;
                         while (EntraGeneral)
                         {
                             Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                             string ComandoCL3 = Console.ReadLine();
                             bool Entra3 = true;
                             int Contador3 = 0;
                             while (Entra3)
                             {
                                 foreach (Personaje_Caracteristica CARVARIA in PersonajeModi.C_VAtributoColeccion)
                                 {
                                     if (CARVARIA.CaracteristicaV.Nombre == ComandoCL3)
                                     {
                                         Contador3 = Contador3 + 1;
                                         Console.WriteLine();
                                         Console.WriteLine("En esta instancia solo puede modificar el valor de la Caracteristica para este presonaje");
                                         Console.WriteLine();
                                         Console.WriteLine("Si desea Modificar el nombre valla al Procedimiento odificar Caracteristica, y el nombre cambiara para cada Personaje");
                                         bool Entra4 = true;
                                         while (Entra4)
                                         {
                                             Console.WriteLine();
                                             CARVARIA.valor = 0;
                                             Console.WriteLine("Escriba el nuevo valor de la Caracteristica ");
                                             Console.WriteLine();
                                             CARVARIA.valor = int.Parse(Console.ReadLine());
                                             Entra4 = false;

                                         }
                                         Entra3 = false;
                                         Entra = false;
                                     }

                                 }
                                 if (Contador3 == 0)
                                 {
                                     Console.WriteLine();
                                     Console.WriteLine("Error la Caracteristica que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                     Console.WriteLine();
                                     Console.WriteLine(PersonajeModi.C_VAtributoColeccion.Count);
                                     Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                     ComandoCL3 = Console.ReadLine();
                                 }

                             }
                             Console.WriteLine();
                             Console.WriteLine("Si desea modificar el valor de otra de las caracteristicas ingrese SI de lo contrario ingrese NO");
                             Console.WriteLine();
                             string Eleccion = Console.ReadLine();
                             if (Eleccion == "SI")
                             {
                                 Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                 ComandoCL3 = Console.ReadLine();
                             }
                             else if (Eleccion == "NO")
                             {
                                 EntraGeneral = false;
                             }
                         }
                         Console.WriteLine();
                         foreach (Personaje_Caracteristica CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                         {
                             Console.Write(CarVarPerso.CaracteristicaV.Nombre);
                             Console.Write(" -> Valor: ");
                             Console.WriteLine(CarVarPerso.valor);
                         }

                     }*/
                    Entra1 = false;
                } 

            }

            Console.WriteLine();
            Console.WriteLine("Su Personaje se a modificado con exito para serceorarse valla a ListarPersonajes");
            Console.WriteLine();

        }
        public void ListarPersonajes()
        {
            foreach (Personaje P in BusinessLogic.PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.Write(P.Id);
                Console.Write("Nombre: ");
                Console.WriteLine(P.Nombre);
                Console.WriteLine();
                foreach (Personaje_Caracteristica PC in Personaje_CaracteristicaBL.Listar())
                {

                }

            }

        }
        public void ListarPersonajesPorRaza()
        {
            foreach (Raza Razas in Raza_List)
            {
                List<Personaje> PersonajesRaza = new List<Personaje>();
                foreach (Personaje Personajes in Personaje_List)
                {

                    if (Personajes.RazaAtributo == Razas)
                    {
                        PersonajesRaza.Add(Personajes);
                    }

                }
                if (PersonajesRaza.Count > 0)
                {
                    Console.WriteLine(Razas.Nombre);
                }
                foreach (Personaje Personajes in PersonajesRaza)
                {
                    Console.Write("{0}", Personajes.Nombre);
                    Console.Write("-> ");
                    Console.WriteLine(Personajes.Id);
                }
                Console.WriteLine();
                PersonajesRaza = new List<Personaje>();

            }

        }
        public void ListarPersonajesPorClase()
        {
            foreach (Clase Clases in Clase_List)
            {
                List<Personaje> PersonajesClase = new List<Personaje>();
                foreach (Personaje Personajes in Personaje_List)
                {

                    if (Personajes.ClaseAtributo == Clases)
                    {
                        PersonajesClase.Add(Personajes);
                    }

                }
                if (PersonajesClase.Count > 0)
                {
                    Console.WriteLine(Clases.Nombre);
                }
                foreach (Personaje Personajes in PersonajesClase)
                {
                    Console.Write("{0}", Personajes.Nombre);
                    Console.Write("-> ");
                    Console.WriteLine(Personajes.Id);
                }
                Console.WriteLine();
                PersonajesClase = new List<Personaje>();

            }
        }
        public void EliminarPersonaje()
        {
            Console.Write("Para ver la lista de Personajes de una Clase elija la Clase de la siguiente lista");
            Console.WriteLine();
            foreach (Clase C in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(C.Id);
                Console.Write(", Nombre : ");
                Console.Write(C.Nombre);
            }

            Console.WriteLine("Lista de los Personajes existentes en el sistema");
            Console.WriteLine();
            foreach (Personaje Personajes in Personaje_List)
            {
                Console.Write("{0}", Personajes.Nombre);
                Console.Write(" -> Nivel: ");
                Console.WriteLine(Personajes.Nivel);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Caracteristica Variable que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Personaje Personajes in Personaje_List)
            {
                if (Personajes.Nombre == Comando)
                {
                    Personaje_List.Remove(Personajes);
                    break;
                }
            }
            foreach (Personaje Personajes in Personaje_List)
            {
                Console.Write("{0}", Personajes.Nombre);
                Console.Write(" -> Nivel: ");
                Console.WriteLine(Personajes.Nivel);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Su Personaje a sido eliminado con exito para serceorarse valla a ListarPersonajes");
            Console.WriteLine();

        }

    }

}
