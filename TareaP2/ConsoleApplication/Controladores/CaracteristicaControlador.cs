using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class CaracteristicaControlador
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public PersonajeControlador PersonajeControlador { get; set; }
        public RazaControlador RazaControlador { get; set; }
        public ClaseControlador ClaseControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variable_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();

        public Caracteristica CrearCaracteristica()
        {
            P_C = new Caracteristica();
            Console.WriteLine("Ingrese Nombre de la nueva Caracteristica Variable");
            Console.WriteLine();
            P_C.Nombre = Console.ReadLine();
            Caracteristica_Variable_List.Add(P_C);
            foreach (Personaje Pers in Personaje_List)
            {
                Pers.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { valor = 1, CaracteristicaV = P_C });
            }

            return P_C;
        }
        public void ModificarCaracteristica()
        {
            Console.WriteLine("Elija de la Caracteristica que desa modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarCaracteristicas();
            Console.WriteLine();
            Console.Write("Ingrese el Nombre de la Caracteristica que desea modificar: ");
            string ComandoCL = Console.ReadLine();
            bool Entra1 = true;
            while (Entra1)
            {
                int Contador = 0;
                foreach (Caracteristica CARVARIA in Caracteristica_Variable_List)
                {

                    if (CARVARIA.Nombre == ComandoCL)
                    {
                        Contador = Contador + 1;
                        Console.WriteLine();
                        Console.WriteLine("En esta Instancia solo se puede modificar el nombre de la caracteristica pues los valores cambian para cada Personaje");
                        Console.WriteLine();
                        CARVARIA.Nombre = null;
                        Console.Write("Escriba el nuevo Nombre de la Caracteristica: ");
                        CARVARIA.Nombre = Console.ReadLine();
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
            Console.WriteLine("Su Caracteristica a sido modificada con exito para serceorarse valla a ListarCaracteristicas");
            Console.WriteLine();

        }
        public void ListarCaracteristicas()
        {
            foreach (Caracteristica CV in Caracteristica_Variable_List)
            {
                Console.Write(CV.Nombre);
                Console.Write(" -> Valor: ");
                Console.WriteLine("No asignado porque varia para cada Personaje ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void EliminarCaracteristica()
        {
            Console.WriteLine("Lista de las Caracteristicas Variables existentes en el sistema");
            Console.WriteLine();
            foreach (Caracteristica CV in Caracteristica_Variable_List)
            {
                Console.Write("{0}", CV.Nombre);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Escriba el nombre de la Caracteristica Variable que desea Eliminar: ");
            string Comando = Console.ReadLine();
            foreach (Caracteristica CV in Caracteristica_Variable_List)
            {
                if (CV.Nombre == Comando)
                {
                    Caracteristica_Variable_List.Remove(CV);
                    break;
                }
            }
            foreach (Personaje PerCarEli in Personaje_List)
            {
                foreach (Personaje_Caracteristica CV in PerCarEli.C_VAtributoColeccion)
                {
                    if (CV.CaracteristicaV.Nombre == Comando)
                    {
                        PerCarEli.C_VAtributoColeccion.Remove(CV);
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Su Caracteristica se a eliminada con exito para serceorarse valla a ListarCaracteristicas");
            Console.WriteLine();

        }
    }
}
