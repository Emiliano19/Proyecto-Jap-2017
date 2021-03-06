﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class PersonajeControlador: Interfaces.PersonajeInterface
    {
        public Personaje PersonajeV { get; set; }
        public RazaControlador RazaControlador = new RazaControlador();
        public ClaseControlador ClaseControlador = new ClaseControlador();
        public CaracteristicaControlador CaracteristicasControlador = new CaracteristicaControlador();

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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
                    Console.WriteLine("Error lo que ha ingresado no es un valor de tipo entero, intente de nuevo");
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
            Console.WriteLine("__________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Razas Existentes en el sistema a continuación siga las instrucciones");
            Console.WriteLine();
            foreach (Raza RazaLI in BusinessLogic.RazaBL.Listar())
            {
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(RazaLI.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(RazaLI.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
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
                    Console.WriteLine("Comando erróneo intente, de nuevo");
                    Console.WriteLine();
                }
                else if (ComandoRA == 1)
                {
                    Console.WriteLine();
                    bool EntraRa2 = true;
                    while (EntraRa2)
                    {
                        Console.Write("Escriba el Id de la Raza elegida: ");
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
            Console.WriteLine("__________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Clases Existentes en el sistema a continuación siga las instrucciones");
            Console.WriteLine();
            foreach (Clase ClaseLI in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
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
                    Console.WriteLine("Comando erróneo, intente de nuevo");
                    Console.WriteLine();
                }
                else if (ComandoCLA == 1)
                {
                    Console.WriteLine();
                    bool EntraCLA2 = true;
                    while (EntraCLA2)
                    {
                        Console.Write("Escriba el Id de la Clase elegida: ");
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
            Console.WriteLine("__________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Características Variables Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            CaracteristicasControlador.ListarCaracteristicas();
            Console.WriteLine();
            Console.WriteLine("Todas se agregarán al Personaje con los valores que usted le debe cargar a Continuacion");
            Console.WriteLine();
            int IdPE = PersonajeBL.Listar().Max(x => x.Id);
            foreach (Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
            {             
                Console.Write(C.Nombre);
                Console.Write(" => Valor: ");
                int valor = int.Parse(Console.ReadLine());
                BusinessLogic.Personaje_CaracteristicaBL.Agregar(IdPE, C.Id, valor);
                Console.WriteLine();
               
            }
            Console.WriteLine("Si desea crear una nueva Característica y agregarla ingrese: 1");
            Console.WriteLine();
            Console.WriteLine("Si desea finalizar el proceso ingrese: 2");
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
                    Console.WriteLine();
                    Console.WriteLine("Comando erróneo, intente de nuevo");
                    Console.WriteLine();
                   
                }
                else if (com == 1)
                {
                    Console.WriteLine();
                    Caracteristica C1 = CaracteristicasControlador.CrearCaracteristica();
                    Console.WriteLine();
                    Console.WriteLine("Si desea crear una nueva Característica y agregarla ingrese: 1");
                    Console.WriteLine();
                    Console.WriteLine("Si desea finalizar el proceso ingrese: 2");
                    Console.WriteLine();
                }
                else if (com == 2)
                {
                    if (CaracteristicaBL.Listar().Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("No existen Características en el Sistema debe crear alguna nueva");
                        Console.WriteLine();
                        Console.WriteLine("Para crear nueva Característica ingrese: 1");
                        Console.WriteLine();
                    }
                    else if (CaracteristicaBL.Listar().Count > 0)
                    {
                        Entra = false;
                    }

                }

            }
            Personaje PX = PersonajeBL.Obtener(IdPE);
            Raza Raz = RazaBL.Obtener(PX.RazaAtributo.Id);
            Caracteristica Car = CaracteristicaBL.Obtener(Raz.Caract_VarRazaAtributo.Id);
            int Plus = Raz.ValorPlus;
            int IdCR = Car.Id;
            Personaje_Caracteristica PCA = Personaje_CaracteristicaBL.Obtener(IdPE, IdCR);
            int Valor = PCA.valor;
            int NewValor = Valor + Plus;
            if (NewValor <= 15)
            {
                Personaje_CaracteristicaBL.Modificar(IdPE, IdCR, NewValor);
            }
            Console.WriteLine();
            return PersonajeV;

        }
        public void ModificarPersonaje()
        {
            Console.WriteLine("Elija el Personaje que desea modificar de la siguiente lista");
            Console.WriteLine();
            foreach(Personaje Per in BusinessLogic.PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Per.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" -> ");
                Console.WriteLine(Per.Nombre);
                Console.WriteLine();
            }
            Console.Write("Ingrese el Id del Personaje que desea modificar: ");
            string comandox = Console.ReadLine();
            int id;
            bool resultx = Int32.TryParse(comandox, out id);
            Personaje P = PersonajeBL.Obtener(id);
            Console.WriteLine();
                    
            bool Entra1 = true;
            while (Entra1)
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione que desea modificar ingresando el numero de la opción: ");
                Console.WriteLine();
                Console.WriteLine(" 1 - Nombre");
                Console.WriteLine(" 2 - Nivel");
                Console.WriteLine(" 3 - Fuerza");
                Console.WriteLine(" 4 - Destreza");
                Console.WriteLine(" 5 - Constitución");
                Console.WriteLine(" 6 - Inteligencia");
                Console.WriteLine(" 7 - Sabiduría");
                Console.WriteLine(" 8 - Carisma");
                Console.WriteLine(" 9 - Raza");
                Console.WriteLine("10 - Clase");
                Console.WriteLine("11 - Característica");
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
                        Console.WriteLine("Comando erróneo, intente de nuevo");
                        ComandoCL2 = int.Parse(Console.ReadLine());
                    }
                    else if (ComandoCL2 == 1)
                    {
                        Console.Write("Nuevo Nombre: ");
                        string NuevoNombre = Console.ReadLine();
                        Console.WriteLine();
                        P.Nombre = NuevoNombre;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 2)
                    {
                        Console.Write("Nuevo Nivel: ");
                        int NuevoNivel = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Nivel = NuevoNivel;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 3)
                    {
                        Console.Write("Nueva Fuerza: ");
                        int NuevaFuerza = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Fuerza = NuevaFuerza;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 4)
                    {
                        Console.Write("Nueva Destreza: ");
                        int NuevaDestreza = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Destreza = NuevaDestreza;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 5)
                    {
                        Console.Write("Nueva Constitución: ");
                        int NuevaConstitucion = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Constitucion = NuevaConstitucion;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 6)
                    {
                        Console.Write("Nueva Inteligencia: ");
                        int NuevaInteligencia = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Inteligencia = NuevaInteligencia;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();


                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 7)
                    {
                        Console.Write("Nueva Sabiduría: ");
                        int NuevaSabiduria = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Sabiduria = NuevaSabiduria;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 8)
                    {
                        Console.Write("Nuevo Carisma: ");
                        int NuevoCarisma = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        P.Carisma = NuevoCarisma;
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Elija la nueva Raza de su Personaje de la siguiente lista");
                        Console.WriteLine();
                        RazaControlador.ListarRazas();
                        Console.Write("Escriba el Id de la Raza elegida: ");
                        int idr = int.Parse(Console.ReadLine());
                        P.RazaAtributo = RazaBL.Obtener(idr);
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Elija la nueva Clase de su Personaje de la siguiente lista");
                        Console.WriteLine();
                        ClaseControlador.ListarClases();
                        Console.Write("Escriba el Id de la Clase elegida: ");
                        int idc = int.Parse(Console.ReadLine());
                        P.ClaseAtributo = ClaseBL.Obtener(idc);
                        int idRazaGenerada = BusinessLogic.PersonajeBL.Modificar(P);
                        Console.WriteLine();

                        Entra = false;
                        Entra1 = false;
                    }
                    else if (ComandoCL2 == 11)
                    {
                        Console.WriteLine();
                        bool EntraGeneral = true;
                        while (EntraGeneral)
                        {
                            Console.WriteLine();
                            Console.WriteLine("En esta instancia solo puede modificar el valor de la Característica para este Personaje");
                            Console.WriteLine();
                            Console.WriteLine("Si desea Modificar el nombre valla al Procedimiento modificar Caracteristica");
                            Console.WriteLine();
                            Console.WriteLine("Elija la Característica que desea modificar de la siguiente lista");
                            Console.WriteLine();
                            foreach (Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
                            {
                                Personaje_Caracteristica Z = BusinessLogic.Personaje_CaracteristicaBL.Obtener(P.Id, C.Id);
                                Console.Write("Id = ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(C.Id);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(", Nombre : ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(C.Nombre);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(", Valor : ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(Z.valor);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                            }
                            bool Entra3 = true;
                            while (Entra3)
                            {
                                Console.Write("Ingrese Id de la Característica elegida: ");
                                string comando = Console.ReadLine();
                                int IdC;
                                bool result = Int32.TryParse(comando, out IdC);
                                Personaje_Caracteristica PCA = BusinessLogic.Personaje_CaracteristicaBL.Obtener(P.Id, IdC);

                                if (PCA != null)
                                {

                                    bool VEntro = true;
                                    while (VEntro)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Escriba el nuevo Valor: ");
                                        string comando1 = Console.ReadLine();
                                        int Valor;
                                        bool result1 = Int32.TryParse(comando1, out Valor);

                                        if(result1 == false)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Error lo que ingreso no es un valor entero, intente de nuevo");
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            BusinessLogic.Personaje_CaracteristicaBL.Modificar(P.Id, IdC, Valor);
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea modificar otra Característica ingrese: 1");
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea finalizar el proceso ingrese: 2");
                                            Console.WriteLine();
                                            Console.Write("Ingrese Comando: ");
                                            string comandow = Console.ReadLine();
                                            int comw;
                                            bool resultw = Int32.TryParse(comandow, out comw);
                                            if (comw != 1 && comw != 2)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Comando erróneo, intente de nuevo");
                                                Console.WriteLine();

                                            }
                                            else if (comw == 1)
                                            {
                                                VEntro = false;
                                                Console.WriteLine();
                                            }
                                            else if (comw == 2)
                                            {
                                                VEntro = false;
                                                Entra3 = false;
                                                Entra = false;
                                                EntraGeneral = false;
                                                Entra1 = false;
                                            }
                                            
                                        }
                                        
                                    }
                                    

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Error la Característica que a elegido no se encuentra en el Sistema, cerciórese de haber ingresado bien el nombre");
                                    Console.WriteLine();
                                    Entra3 = false;
                                }

                            }

                        }

                    }   
                       
                } 

            }

        }
        public void ListarPersonajes()
        {
            Console.WriteLine("Se muestra Nombre e Id de todos los Personajes a Continuación");
            Console.WriteLine();
            foreach(Personaje PL in BusinessLogic.PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(PL.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" -> Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PL.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            Console.WriteLine("Para ver todos los datos de un personaje escriba el Id del Personaje que escogió a continuación");
            bool Entro = true;
            while (Entro)
            {
                Console.WriteLine();
                Console.Write("Ingrese el Id: ");
                string Comando = Console.ReadLine();
                int Idc;
                bool result = Int32.TryParse(Comando, out Idc);

                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor entero, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    foreach (Personaje PX in BusinessLogic.PersonajeBL.Listar())
                    {
                        if(PX.Id == Idc)
                        {
                            Console.Write("Id: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(PX.Id);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Nombre: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(PX.Nombre);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Raza: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(PX.RazaAtributo.Nombre);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Clase: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(PX.ClaseAtributo.Nombre);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Características: ");
                            foreach (Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
                            {
                                Personaje_Caracteristica Z = BusinessLogic.Personaje_CaracteristicaBL.Obtener(PX.Id, C.Id);
                                Console.Write(C.Nombre);
                                Console.Write(" -> Valor : ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(Z.valor);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine("Habilidad Especial: ");
                            foreach (Habilidad_Especial HE in HabilidadEspecialBL.Listar())
                            {
                                Personaje_HE PERSH = Personaje_HEBL.Obtener(PX.Id, HE.Id);
                                if(PERSH != null)
                                {
                                    Console.Write("Id: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(HE.Id);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(", Nombre: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(HE.Nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                            }

                        }
        
                    }
                    Entro = false;
                }

            }

        }
        public void ListarPersonajesPorRaza()
        {
            Console.WriteLine("Para ver los Personajes que pertenecen a una Raza elija la Raza de la siguiente lista");
            Console.WriteLine();
            foreach (Raza R in BusinessLogic.RazaBL.Listar())
            {
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(R.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(R.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            bool Entro = true;
            while (Entro)
            {
                Console.Write("Ingrese el Id de la Raza elegida: ");
                string Comando = Console.ReadLine();
                int Idr;
                bool result = Int32.TryParse(Comando, out Idr);

                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor de Id correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    foreach (Raza RA in BusinessLogic.RazaBL.Listar())
                    {
                        if (RA.Id == Idr)
                        {
                            Raza Ra = RazaBL.Obtener(RA.Id);
                            Console.Write(Ra.Nombre);
                            Console.WriteLine(":");
                            foreach (Personaje PX in BusinessLogic.PersonajeBL.Listar())
                            {
                                if (PX.RazaAtributo.Id == Idr)
                                {
                                    Console.Write("Id: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(PX.Id);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" Nombre: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(PX.Nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                            }
                            Entro = false;
                        }

                    }

                }

            }

        }
        public void ListarPersonajesPorClase()
        {
            Console.WriteLine("Para ver los Personajes que pertenecen a una Clase elija la Clase de la siguiente lista");
            Console.WriteLine();
            foreach (Clase C in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(C.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", Nombre : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(C.Nombre);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            bool Entro = true;
            while (Entro)
            {
                Console.Write("Ingrese el Id de la Clase elegida: ");
                string Comando = Console.ReadLine();
                int Idc;
                bool result = Int32.TryParse(Comando, out Idc);

                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor de Id correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    foreach (Clase CH in BusinessLogic.ClaseBL.Listar())
                    {
                        if (CH.Id == Idc)
                        {
                            Clase C = ClaseBL.Obtener(CH.Id);
                            Console.Write(C.Nombre);
                            Console.WriteLine(":");
                            foreach (Personaje PX in BusinessLogic.PersonajeBL.Listar())
                            {
                                if (PX.ClaseAtributo.Id == Idc)
                                {
                                    Console.Write("Id: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(PX.Id);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" Nombre: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(PX.Nombre);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                            }
                            Entro = false;
                        }

                    }

                }

            }
            
        }
        public void EliminarPersonaje()
        {
            Console.WriteLine("Lista de los Personajes existentes en el sistema");
            Console.WriteLine();
            foreach (Personaje PX in PersonajeBL.Listar())
            {
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(PX.Id);
                Console.ResetColor();
                Console.Write(" Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PX.Nombre);
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine("Escriba el Id del Personaje que desea Eliminar a continuación");
            Console.WriteLine();
            bool Entro = true;
            while (Entro)
            {
                Console.Write("Ingrese el Id: ");
                string Comando = Console.ReadLine();
                int IdP;
                bool result = Int32.TryParse(Comando, out IdP);

                if (result == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error lo que ingreso no es un valor de Id correcto, intente de nuevo");
                    Console.WriteLine();
                }
                else
                {
                    foreach (Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
                    {
                        BusinessLogic.Personaje_CaracteristicaBL.Eliminar(IdP, C.Id);
                    }
                    PersonajeBL.Eliminar(IdP);
                    Entro = false;
                    Console.WriteLine();
                }

            }

        }
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
