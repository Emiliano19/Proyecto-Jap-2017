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
        public CaracteristicaControlador CaracteristicasControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


        public Raza CrearRaza()
        {
            Raza Raza = new Raza();
            Console.Write("Ingrese Nombre de la nueva Raza: ");
            Raza.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese Descripcion de la nueva Raza: ");
            Raza.Descripcion = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Elija de la siguiente lista la caracteristica asociada a la nueva Raza: ");
            Console.WriteLine();
         //   CaracteristicasControlador.ListarCaracteristicas();
            Console.Write("Ingrese el Id de la Caracteristica elejida: ");
            int ValorPluss = int.Parse(Console.ReadLine());
            bool Entra4 = true;
            while (Entra4)
            {
                Console.WriteLine();
                if (ValorPluss > 5)
                {
                    Console.WriteLine("Error el Valor Plus no puede se mayor a 5 intente denuevo con un valor menor  u igual a 5");
                    ValorPluss = int.Parse(Console.ReadLine());
                }
                else
                {
                    Entra4 = false;
                    
                }
            }
            int idRazaGenerada = BusinessLogic.RazaBL.Add(Raza);

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
            Console.WriteLine();
            ListarRazas();

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
            // LISTO RAZAS
            //SOLICITO ID
            // Raza r = BL.Obtener(id)
            // SI ENCUENTRO UNA RAZA r CON ESE ID, PREGUNTAS DE QUE SE DESEA MODIFICAR.
                // r.Atributo A modificar = lo que ingresa.
                // BL.ModificarRaza(r)
            // SI NO, SOLICITAR NUEVAMENE ID.
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
                            Console.WriteLine();
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
                            R.Descripcion = null;
                            Console.Write("Escriba la nueva Descripcion de la Raza: ");
                            R.Descripcion = Console.ReadLine();
                            Entra = false;

                        }
                        else if (ComandoCL2.Equals("Todo"))
                        {
                            Console.WriteLine();
                            R.Nombre = null;
                            Console.Write("Escriba el nuevo Nombre de la Raza: ");
                            R.Nombre = Console.ReadLine();
                            Console.WriteLine();
                            R.Descripcion = null;
                            Console.Write("Escriba la nueva Descripcion de la Raza: ");
                            R.Descripcion = Console.ReadLine();
                            Entra = false;

                        }

                    }
                    Entra1 = false;
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
                Console.Write(", Descripcion : ");
                Console.WriteLine(RazaLI.Descripcion);
                Console.WriteLine();
            }

        }
        public void EliminarRaza()
        {
            Console.WriteLine("Lista de las Razas existentes en el sistema");
            Console.WriteLine();
            ListarRazas();
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Raza que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Raza Razas in Raza_List)
            {
                if (Razas.Nombre == Comando)
                {
                    foreach (Personaje Peri in Personaje_List)
                    {
                        if (Peri.RazaAtributo == Razas)
                        {
                            Peri.RazaAtributo = null;
                            Peri.RazaAtributo = Raza_List.ElementAt(0);
                        }
                    }
                    Raza_List.Remove(Razas);
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Su Raza a sido eliminada con exito para serceorarse valla a ListarRazas");
            Console.WriteLine();

        }

    }
}
