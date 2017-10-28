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


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


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
            Console.Write("Ingrese el Id de la Caracteristica elejida: ");
            int IdCar = int.Parse(Console.ReadLine());
            Caracteristica C = CaracteristicaBL.Obtener(IdCar);
            Raza.Caract_VarRazaAtributo = C;
            int idRazaGenerada = BusinessLogic.RazaBL.Agregar(Raza);
            Console.WriteLine();
            if (idRazaGenerada > 0)
            {
                Console.WriteLine("La Raza se agregao correctamente en la BD");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se agrega la Raza en la BD");
                Console.WriteLine();
            }

            return Raza;
        }
        public void ModificarRaza()
        {
            Console.WriteLine("Elija la Raza que desa modificar de la siguiente lista");
            Console.WriteLine();
            ListarRazas();
            Console.Write("Ingrese el Id de la Raza que desea modificar: ");
            int ComandoRA = int.Parse(Console.ReadLine());
            int id = Convert.ToInt32(ComandoRA);
            Raza R = RazaBL.Obtener(id);
            bool Entra1 = true;
            while (Entra1)
            {
                if (R != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Selecione que desea modificar");
                    Console.WriteLine();
                    Console.WriteLine("Si desea modificar el nombre de la Raza ingrese el comando Nombre");
                    Console.WriteLine();
                    Console.WriteLine("Si desea Modificar Descripcion de la Raza ingrese el comando Descripcion");
                    Console.WriteLine();
                    Console.WriteLine("Si desea Modificar todos los atributos de la Raza ingrese el comando Todo");
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
                            Console.Write("Ingrese el nuevo Nombre de la Raza: ");
                            string NuevoNombre = Console.ReadLine();
                            R.Nombre = NuevoNombre;
                            int idRazaGenerada = BusinessLogic.RazaBL.Modificar(R);
                            Console.WriteLine();
                            if (idRazaGenerada > 0)
                            {
                                Console.WriteLine("La Raza se Modifico correctamente en la BD");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("No se pudo Modifico la Raza en la BD");
                                Console.WriteLine();
                            }
                            Entra = false;

                        }
                        else if (ComandoCL2.Equals("Descripcion"))
                        {
                            Console.WriteLine();
                            Console.Write("Ingrese la nueva Descripción de la Raza: ");
                            string NuevaDescripcion = Console.ReadLine();
                            Console.WriteLine();
                            R.Descripcion = NuevaDescripcion;
                            int idRazaGenerada = BusinessLogic.RazaBL.Modificar(R);
                            Console.WriteLine();
                            if (idRazaGenerada > 0)
                            {
                                Console.WriteLine("La Raza se Modifico correctamente en la BD");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("No se pudo Modifico la Raza en la BD");
                                Console.WriteLine();
                            }
                            Entra = false;
                        }
                        else if (ComandoCL2.Equals("Todo"))
                        {
                            Console.WriteLine();
                            Console.Write("Ingrese el nuevo Nombre de la Raza: ");
                            string NuevoNombre = Console.ReadLine();
                            Console.WriteLine();
                            R.Nombre = NuevoNombre;
                            Console.Write("Ingrese la nueva Descripción de la Raza: ");
                            string NuevaDescripcion = Console.ReadLine();
                            R.Descripcion = NuevaDescripcion;
                            int idRazaGenerada = BusinessLogic.RazaBL.Modificar(R);
                            Console.WriteLine();
                            if (idRazaGenerada > 0)
                            {
                                Console.WriteLine("La Raza se Modifico correctamente en la BD");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("No se pudo Modifico la Raza en la BD");
                                Console.WriteLine();
                            }
                            Entra = false;
                        }

                    }
                    Entra1 = false;
                }
                else
                {
                    Console.WriteLine("No se a encontrado una raza con ese Id en el sistema intente ingresando un nuevo Id");
                    Console.WriteLine();
                    Console.Write("Ingrese el Id de la Raza que desea modificar: ");
                    int Comando = int.Parse(Console.ReadLine());
                    int id1 = Convert.ToInt32(ComandoRA);
                    Raza Ra = RazaBL.Obtener(id);

                }
            }
            Console.WriteLine();

        }
        public void ListarRazas()
        {
            foreach(Raza RazaLI in BusinessLogic.RazaBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(RazaLI.Id);
                Console.Write(", Nombre : ");
                Console.Write(RazaLI.Nombre);
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
