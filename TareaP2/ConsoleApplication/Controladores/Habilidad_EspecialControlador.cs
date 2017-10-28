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
        public Clase Clase = new Clase();
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
            Console.WriteLine("Se a modificado con exito la Habilidad Especial para serciorarse valla a ListarHabilidadesEspeciales");
            Console.WriteLine();
        }
        public void ListarHabilidadesEspeciales()
        {
            foreach (Habilidad_Especial HESLI in HabilidadEspecialBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(HESLI.Id);
                Console.Write(", Nombre : ");
                Console.Write(HESLI.Nombre);
                Console.Write(", Descripción : ");
                Console.WriteLine(HESLI.Descripcion);
                Console.WriteLine();
            }
        }
        public void ListarHabilidadHespecialPorClase()
        {
            Console.WriteLine("Se enlistan a continuacion las Clases");
            Console.WriteLine();
            foreach (Clase Clases in BusinessLogic.ClaseBL.Listar())
            {
                Console.Write("Id = ");
                Console.Write(Clases.Id);
                Console.Write(" -> ");
                Console.Write("Nombre: ");
                Console.WriteLine(Clases.Nombre);
            }
            Console.WriteLine();
            Console.WriteLine("Para ver la lista de Habilidades de una Clase escriba el Id de la Clase a continuación");
            Console.WriteLine();
            Console.Write("Ingrese el Id de la Clase elejida: ");
            int Idelejido = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (Clase_HE CH in BusinessLogic.Clase_HEBL.Listar())
            {
                if (CH.IdC == Idelejido)
                {
                    Clase C = ClaseBL.Obtener(CH.IdC);
                    Console.Write(C.Nombre);
                    Console.WriteLine(":");
                    foreach (Habilidad_Especial CH2 in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Clase_HE CH5 = BusinessLogic.Clase_HEBL.Obtener(C.Id, CH2.Id);
                        if(CH5 != null)
                        {
                            Habilidad_Especial H = HabilidadEspecialBL.Obtener(CH5.IdH);
                            Console.Write("Id = ");
                            Console.Write(H.Id);
                            Console.Write(" -> ");
                            Console.Write("Nombre: ");
                            Console.WriteLine(H.Nombre);
                        }
                        
                    }
                    Console.WriteLine();
                    break;
                }
                
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
