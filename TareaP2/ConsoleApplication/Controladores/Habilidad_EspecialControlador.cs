using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class Habilidad_EspecialControlador
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public RazaControlador RazaControlador { get; set; }
        public ClaseControlador ClaseControlador { get; set; }
        public CaracteristicaControlador CaracteristicasControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();


        public Habilidad_Especial CrearHabilidadHespecial()
        {
            H_E = new Habilidad_Especial();
            Console.Write("Ingrese Nombre de la nueva Habilidad Especial: ");
            H_E.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese Descripcion de la nueva Habilidad Especial: ");
            H_E.Descripcion = Console.ReadLine();
            Habilidad_Especial_List.Add(H_E);

            return H_E;
        }
        public void ModificarHabilidadEspecial()
        {
            Console.WriteLine("Elija de la Habilidad Especial que desa modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarHabilidadesEspeciales();
            Console.WriteLine();
            Console.Write("Ingrese el Nombre de la Habilidad Especiale que desea modificar: ");
            string ComandoHE = Console.ReadLine();
            bool Entra1 = true;
            while (Entra1)
            {
                int Contador = 0;

                foreach (Habilidad_Especial HE in Habilidad_Especial_List)
                {

                    if (HE.Nombre == ComandoHE)
                    {
                        Contador = Contador + 1;
                        Console.WriteLine();
                        Console.WriteLine("Selecione que desea modificar");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar el nombre de la Habilidad Especiale ingrese el comando Nombre");
                        Console.WriteLine();
                        Console.WriteLine("Si desea Modificar Descripcion de la Habilidad Especiale ingrese el comando Descripcion");
                        Console.WriteLine();
                        Console.WriteLine("Si desea Modificar todos los Atributos de la Habilidad Especiale ingrese el comando Todo");
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        string ComandoHE2 = Console.ReadLine();
                        bool Entra = true;
                        while (Entra)
                        {

                            if (!ComandoHE2.Equals("Nombre") && !ComandoHE2.Equals("Descripcion") && !ComandoHE2.Equals("Todo"))
                            {
                                Console.WriteLine("Comando Erroneo intente denuevo");
                                ComandoHE2 = Console.ReadLine();
                            }
                            if (ComandoHE2.Equals("Nombre"))
                            {
                                Console.WriteLine();
                                HE.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Habilidad Especial: ");
                                HE.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoHE2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                HE.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Habilidad Especial: ");
                                HE.Descripcion = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoHE2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                HE.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Habilidad Especial:  ");
                                HE.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                HE.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Habilidad Especial: ");
                                HE.Descripcion = Console.ReadLine();
                                Entra = false;
                            }

                        }
                        Entra1 = false;
                    }

                }

                if (Contador == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error la Habilidad Especiale que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                    Console.WriteLine();
                    Console.Write("Escriba el Nombre de la Habilidad Especial que desea modificar: ");
                    ComandoHE = Console.ReadLine();
                }

            }
            Console.WriteLine();
            Console.WriteLine("Se a modificado con exito la Habilidad Especial para serciorarse valla a ListarHabilidadEspecial");
            Console.WriteLine();
        }
        public void ListarHabilidadesEspeciales()
        {
            IEnumerable<Habilidad_Especial> NHabilidad_Especial_List = Habilidad_Especial_List.OrderBy(HaEs => HaEs.Id);

            foreach (Habilidad_Especial HabiEspec in Habilidad_Especial_List)
            {
                Console.Write(HabiEspec.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(HabiEspec.Descripcion);
                Console.WriteLine();
            }
        }
        public void ListarHabilidadHespecialPorClase()
        {
            foreach (Clase Clases in Clase_List)
            {
                Console.Write(Clases.Nombre);
                Console.WriteLine(":");
                foreach (Habilidad_Especial HECLASE in Clases.HE_AtributoColeccion)
                {
                    Console.Write(HECLASE.Nombre);
                    Console.Write(" -> Descripcion: ");
                    Console.WriteLine(HECLASE.Descripcion);
                }
                Console.WriteLine();
            }
        }
        public void EliminarHabilidadEspecial()
        {
            Console.WriteLine("Lista de Hsabilidades Especiales existentes en el sistema");
            Console.WriteLine();
            foreach (Habilidad_Especial HE in Habilidad_Especial_List)
            {
                Console.Write("{0}", HE.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(HE.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Habilidad Especial que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Habilidad_Especial HE in Habilidad_Especial_List)
            {
                if (HE.Nombre == Comando)
                {
                    Habilidad_Especial_List.Remove(HE);
                    break;
                }
            }
            foreach (Habilidad_Especial HE in Habilidad_Especial_List)
            {
                Console.Write("{0}", HE.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(HE.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Su Habilidad Especial a sido eliminada con exito para serceorarse valla a ListarHabilidadesEspeciales");
            Console.WriteLine();
        }

    }

}
