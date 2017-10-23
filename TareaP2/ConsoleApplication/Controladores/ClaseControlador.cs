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
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public RazaControlador RazaControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador { get; set; }
        public CaracteristicaControlador CaracteristicasControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variable_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


        public Clase CrearClase()
        {
            Clase Clase = new Clase();
            IEnumerable<Clase> NClase_List = Clase_List.OrderBy(Clas => Clas.Id);
            int z = 1;
            if (Clase_List.Count == 0)
            {
                Clase.Id = 1;
            }
            else if (Clase_List.Count > 0)
            {
                foreach (Clase Clas in NClase_List)
                {
                    if (Clas.Id == z)
                    {
                        z = z + 1;
                    }
                    else if (Clas.Id != z)
                    {
                        Clase.Id = z;
                        break;
                    }
                }
                if (Clase.Id == 0)
                {
                    Clase.Id = Clase_List.Count + 1;
                }
            }
            Console.Write("Ingrese Nombre de la nueva Clase: ");
            Clase.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese Descripcion de la nueva Clase: ");
            Clase.Descripcion = Console.ReadLine();
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Para finalizar de la siguiente lista elija las Habilidades Especiales que desee que tenga la nueva Clase");
            Console.WriteLine();
            HEControlador.ListarHabilidadesEspeciales();
            Console.WriteLine();
            Console.Write("Ingrese Nombre de la Habilidad Elejida: ");
            string HEElegi = Console.ReadLine();
            bool EntraClash = true;
            while (EntraClash)
            {
                Console.WriteLine();
                foreach (Habilidad_Especial HESS in Habilidad_Especial_List)
                {
                    if (HESS.Nombre == HEElegi)
                    {
                        Clase.HE_AtributoColeccion.Add(HESS);
                    }
                }
                Console.Write("Si desea agregar mas Habilidades ingrese SI de lo contrario NO: ");
                string SiNo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                if (SiNo == "SI")
                {
                    Console.Write("Ingrese Nombre de la Habilidad Elegida: ");
                    Console.WriteLine();
                    HEElegi = Console.ReadLine();
                }
                else if (SiNo == "NO")
                {
                    EntraClash = false;
                }
            }
            Console.WriteLine("Si desea agregar otra habilidad Especial que no exista en el sistema ingrese Nueva de lo contrario Siguiente");
            Console.WriteLine();
            Console.Write("Ingrese comando: ");
            string ComandoHE = Console.ReadLine();
            Console.WriteLine();
            bool EntraHE = true;
            while (EntraHE)
            {

                if (!ComandoHE.Equals("Siguiente") && !ComandoHE.Equals("Nueva"))
                {
                    Console.WriteLine("Comando Erroneo intente denuevo");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoHE = Console.ReadLine();
                }
                if (ComandoHE.Equals("Siguiente"))
                {
                    if (Habilidad_Especial_List.Count == 0)
                    {
                        Console.WriteLine("No existen  Habilidades Especiales en el Sistema debe crear alguna nueva ingresando el comando Nueva");
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        ComandoHE = Console.ReadLine();
                    }
                    else if (Habilidad_Especial_List.Count > 0)
                    {
                        EntraHE = false;
                    }

                }
                if (ComandoHE.Equals("Nueva"))
                {
                    Habilidad_Especial aux = HEControlador.CrearHabilidadHespecial();
                    Clase.HE_AtributoColeccion.Add(aux);
                    Console.WriteLine();
                    Console.WriteLine("Ingrese Siguiente o Nueva");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoHE = Console.ReadLine();
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            Clase_List.Add(Clase);

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
            IEnumerable<Clase> NClase_List = Clase_List.OrderBy(Clas => Clas.Id);
            foreach (Clase Clases in NClase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
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
