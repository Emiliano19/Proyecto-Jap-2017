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
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E = new Habilidad_Especial();
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public RazaControlador RazaControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador = new Habilidad_EspecialControlador();
        public CaracteristicaControlador CaracteristicasControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variable_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


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

                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Seleccione las Habilidades Especiales que desee que tenga la nueva Clase ingresando su Id");
                    Console.WriteLine();
                    HEControlador.ListarHabilidadesEspeciales();
                    Console.Write("Ingrese Id de la Habilidad elejida: ");
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
                            Console.WriteLine();
                            if(com != 1 && com != 2 && com != 3 || result3 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El comando ingresado no es correcto, intente de nuevo");
                                Console.WriteLine();
                            }
                            if (com == 1)
                            {
                                Console.Write("Ingrese Id de la Habilidad elejida: ");
                                string comando2 = Console.ReadLine();
                                int IdC2;
                                bool result2 = Int32.TryParse(comando2, out IdC2);
                                H = HabilidadEspecialBL.Obtener(IdC2);
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
            Console.WriteLine();
            

            return Clase;
        }
        public void ModificarClase()
        {
            Console.WriteLine("Elija de la Clase que desa modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarClases();
            Console.WriteLine();
            Console.Write("Ingrese el Nombre de la Clase que desea modificar: ");
            string ComandoCL = Console.ReadLine();
            bool Entra1 = true;
            while (Entra1)
            {
                int Contador = 0;

                foreach (Clase Clases in Clase_List)
                {

                    if (Clases.Nombre == ComandoCL)
                    {
                        Contador = Contador + 1;
                        Console.WriteLine();
                        Console.WriteLine("Selecione que desea modificar");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar el nombre de la Clase ingrese el comando Nombre");
                        Console.WriteLine();
                        Console.WriteLine("Si desea Modificar Descripcion de la Clase ingrese el comando Descripcion");
                        Console.WriteLine();
                        Console.WriteLine("Si desea Modificar todos los Atributos de la Clase ingrese el comando Todo");
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        string ComandoCL2 = Console.ReadLine();
                        bool Entra = true;
                        while (Entra)
                        {
                            if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Descripcion") && !ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine("Comando Erroneo intente denuevo");
                                ComandoCL2 = Console.ReadLine();
                            }
                            if (ComandoCL2.Equals("Nombre"))
                            {
                                Console.WriteLine();
                                Clases.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Clase: ");
                                Clases.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Clase: ");
                                Clases.Descripcion = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Clases.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Clase: ");
                                Clases.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Clase: ");
                                Clases.Descripcion = Console.ReadLine();
                                Entra = false;
                            }

                        }
                        Entra1 = false;
                    }

                }

                if (Contador == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error la Clase que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                    Console.WriteLine();
                    Console.Write("Escriba el Nombre de la clase que desea modificar: ");
                    ComandoCL = Console.ReadLine();
                }

            }
            Console.WriteLine();
            Console.WriteLine("Su Clase se a modificado con esxito para serciorarse valla a ListarClase");
            Console.WriteLine();

        }
        public void ListarClases()
        {
            foreach (Clase ClaseLI in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(ClaseLI.Id);
                Console.Write(" -> ");
                Console.Write("Nombre : ");
                Console.Write(ClaseLI.Nombre);
                Console.Write(", Descripcion : ");
                Console.WriteLine(ClaseLI.Descripcion);
                Console.WriteLine();
            }
        }
        public void EliminarClase()
        {
            Console.WriteLine("Lista de las Clases existentes en el sistema");
            Console.WriteLine();
            ListarClases();
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Clase que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Clase Clases in Clase_List)
            {
                if (Clases.Nombre == Comando)
                {
                    foreach (Personaje Peri in Personaje_List)
                    {
                        if (Peri.ClaseAtributo == Clases)
                        {
                            Peri.ClaseAtributo = null;
                            Peri.ClaseAtributo = Clase_List.ElementAt(0);
                        }
                    }
                    Clase_List.Remove(Clases);
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Su Clase a sido eliminada con exito para serceorarse valla a ListarClases");
            Console.WriteLine();

        }

    }

}
