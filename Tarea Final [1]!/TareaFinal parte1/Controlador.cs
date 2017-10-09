using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Controlador : ISistema
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }       
        public Caracteristica_Variable P_C { get; set; }
        

        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica_Variable> Caracteristica_Variabli_List = new List<Caracteristica_Variable>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();

        public Habilidad_Especial CrearHabilidadHespecial()
        {
            H_E = new Habilidad_Especial();
            IEnumerable<Habilidad_Especial> NHabilidad_Especial_List = Habilidad_Especial_List.OrderBy(HaEs => HaEs.Id);
            int z = 1;
            if (Habilidad_Especial_List.Count == 0)
            {
                H_E.Id = 1;
            }
            else if (Habilidad_Especial_List.Count > 0)
            {
                foreach (Habilidad_Especial HE in NHabilidad_Especial_List)
                {
                    if (HE.Id == z)
                    {
                        z = z + 1;
                    }
                    else if (HE.Id != z)
                    {
                        H_E.Id = z;
                        break;
                    }
                }
                if (H_E.Id == 0)
                {
                    H_E.Id = Habilidad_Especial_List.Count + 1;
                }
            }
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

            foreach(Habilidad_Especial HabiEspec in Habilidad_Especial_List)
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
                foreach(Habilidad_Especial HECLASE in Clases.HE_AtributoColeccion)
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
            ListarHabilidadesEspeciales();
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
                    Habilidad_Especial aux = CrearHabilidadHespecial();
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
        public Raza CrearRaza()
        {
            Raza = new Raza();
            IEnumerable<Raza> NRaza_List = Raza_List.OrderBy(Raz => Raz.Id);
            int z = 1;
            if (Raza_List.Count == 0)
            {
                Raza.Id = 1;
            }
            else if (Raza_List.Count > 0)
            {
                foreach (Raza Raz in NRaza_List)
                {
                    if (Raz.Id == z)
                    {
                        z = z + 1;
                    }
                    else if (Raz.Id != z)
                    {
                        Raza.Id = z;
                        break;
                    }
                }
                if (Raza.Id == 0)
                {
                    Raza.Id = Raza_List.Count + 1;
                }
            }
            Console.Write("Ingrese Nombre de la nueva Raza: ");
            Raza.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Raza");
            Raza.Descripcion = Console.ReadLine();
            Console.Write("Ingrese el valor del plus que desea sumarle a la caracteristica elegida: ");
            Raza.ValorPluss = int.Parse(Console.ReadLine());
            bool Entra4 = true;
            while (Entra4)
            {
                Console.WriteLine();
                if (Raza.ValorPluss > 5)
                {
                    Console.WriteLine("Error el Valor Plus no puede se mayor a 5 intente denuevo con un valor menor  u igual a 5");
                    Raza.ValorPluss = int.Parse(Console.ReadLine());
                }
                else
                {
                    Entra4 = false;
                }
            }
            
            Raza_List.Add(Raza);
            Console.WriteLine();
            ListarRazas();

            return Raza;    
        }
        public void ModificarRaza()
        {
            Console.WriteLine("Elija de la Raza que desa modificar de la siguiente lista");
            Console.WriteLine();
            Console.WriteLine();
            ListarRazas();
            Console.WriteLine();
            Console.Write("Ingrese el Nombre de la Raza que desea modificar: ");
            string ComandoRA = Console.ReadLine();
            bool Entra1 = true;
            while (Entra1)
            {
                int Contador = 0;

                foreach (Raza Razas in Raza_List)
                {

                    if (Razas.Nombre == ComandoRA)
                    {
                        Contador = Contador + 1;
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
                                Razas.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Raza: ");
                                Razas.Nombre = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Raza: ");
                                Razas.Descripcion = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Razas.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre de la Raza: ");
                                Razas.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.Write("Escriba la nueva Descripcion de la Raza: ");
                                Razas.Descripcion = Console.ReadLine();
                                Entra = false;

                            }

                        }
                        Entra1 = false;
                    }

                }

                if (Contador == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error la Raza que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                    Console.WriteLine();
                    Console.Write("Escriba el Nombre de la Raza que desea modificar: ");
                    ComandoRA = Console.ReadLine();
                }

            }
            Console.WriteLine();
            Console.WriteLine("Su Raza se a modificado con esxito para serciorarse valla a ListarRazas");
            Console.WriteLine();

        }
        public void ListarRazas()
        {
            IEnumerable<Raza> NRaza_List = Raza_List.OrderBy(Raz => Raz.Id);

            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
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

        public Caracteristica_Variable CrearCaracteristica()
        {
            P_C = new Caracteristica_Variable();
            IEnumerable<Caracteristica_Variable> NCaracteristica_Variable_List = Caracteristica_Variabli_List.OrderBy(PECA => PECA.Id);
            int z = 1;                 
            if (Caracteristica_Variabli_List.Count == 0)
            {
                P_C.Id = 1;
            }
            else if (Caracteristica_Variabli_List.Count > 0)
            {
                foreach (Caracteristica_Variable CarV in NCaracteristica_Variable_List)
                {
                    if (CarV.Id == z)
                    {
                        z = z + 1;
                    }
                    else if (CarV.Id != z)
                    {
                        P_C.Id = z;
                        break;
                    }
                }
                if (P_C.Id == 0)
                {
                    P_C.Id = Caracteristica_Variabli_List.Count + 1;
                }
            }
            Console.WriteLine("Ingrese Nombre de la nueva Caracteristica Variable");
            Console.WriteLine();
            P_C.Nombre = Console.ReadLine();
            Caracteristica_Variabli_List.Add(P_C);
            foreach (Personaje Pers in Personaje_List)
            {
                Pers.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { valor = 1, CaracteristicaV = P_C});
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
                foreach (Caracteristica_Variable CARVARIA in Caracteristica_Variabli_List)
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
            IEnumerable<Caracteristica_Variable> NCaracteristica_Variable_List = Caracteristica_Variabli_List.OrderBy(Car => Car.Id);

            foreach (Caracteristica_Variable CV in NCaracteristica_Variable_List)
            {
                Console.Write(CV.Nombre);
                Console.Write(" -> Valor: ");
                Console.Write("No asignado porque varia para cada Personaje ");
            }
            Console.WriteLine();
        }
        public void EliminarCaracteristica()
        {
            Console.WriteLine("Lista de las Caracteristicas Variables existentes en el sistema");
            Console.WriteLine();
            foreach (Caracteristica_Variable CV in Caracteristica_Variabli_List)
            {
                Console.Write("{0}", CV.Nombre);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Escriba el nombre de la Caracteristica Variable que desea Eliminar: ");
            string Comando = Console.ReadLine();
            foreach (Caracteristica_Variable CV in Caracteristica_Variabli_List)
            {
                if (CV.Nombre == Comando)
                {
                    Caracteristica_Variabli_List.Remove(CV);
                    break;
                }
            }
            foreach(Personaje PerCarEli in Personaje_List)
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
        public Personaje CrearPersonaje()
        {
            IEnumerable<Personaje> NPersonaje_List = Personaje_List.OrderBy(Per => Per.Id);
            int z = 1;
            Personaje PersonajeX = new Personaje();

            if (Personaje_List.Count == 0)
            {
                PersonajeX.Id = 1;
            }
            else if (Personaje_List.Count > 0)
            {
                foreach (Personaje Per in NPersonaje_List)
                {
                    if (Per.Id == z)
                    {
                        z = z + 1;
                    }
                    else if (Per.Id != z)
                    {
                        PersonajeX.Id = z;
                        break;
                    }
                }
                if (PersonajeX.Id == 0)
                {
                    PersonajeX.Id = Personaje_List.Count + 1;
                }
            }
            Console.WriteLine("Complete los datos de su nuevo Personaje");
            Console.WriteLine();
            Console.Write("Ingrese Nombre del Personaje: ");
            PersonajeX.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese Nivel del Personaje: ");
            PersonajeX.Nivel = int.Parse(Console.ReadLine());
            while (PersonajeX.Nivel > 10 || PersonajeX.Nivel <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Nivel del Personaje: ");
                PersonajeX.Nivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Fuerza del Personaje: ");
            PersonajeX.Fuerza = int.Parse(Console.ReadLine());
            while (PersonajeX.Fuerza > 10 || PersonajeX.Fuerza <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Fuerza del Personaje: ");
                PersonajeX.Fuerza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Desztreza del Personaje: ");
            PersonajeX.Destreza = int.Parse(Console.ReadLine());
            while (PersonajeX.Destreza > 10 || PersonajeX.Destreza <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Desztreza del Personaje: ");
                PersonajeX.Destreza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Constitución del Personaje: ");
            PersonajeX.Constitucion = int.Parse(Console.ReadLine());
            while (PersonajeX.Constitucion > 10 || PersonajeX.Constitucion <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Constitución del Personaje: ");
                PersonajeX.Constitucion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Inteligencia del Personaje: ");
            PersonajeX.Inteligencia = int.Parse(Console.ReadLine());
            while (PersonajeX.Inteligencia > 10 || PersonajeX.Inteligencia <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Inteligencia del Personaje: ");
                PersonajeX.Inteligencia = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Sabiduria del Personaje: ");
            PersonajeX.Sabiduria = int.Parse(Console.ReadLine());
            while (PersonajeX.Sabiduria > 10 || PersonajeX.Sabiduria <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Sabiduria del Personaje: ");
                PersonajeX.Sabiduria = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Ingrese Carisma del Personaje: ");
            PersonajeX.Carisma = int.Parse(Console.ReadLine());
            while (PersonajeX.Carisma > 10 || PersonajeX.Carisma <= 0)
            {
                Console.WriteLine("Error el Nivel no puede ser menor o igual a 0 ni mayor a 10, intente denuevo");
                Console.WriteLine();
                Console.Write("Ingrese Carisma del Personaje: ");
                PersonajeX.Carisma = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Razas Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Si Elige Raza existente Ingrese el comando Existente de lo contrario ingrese Nueva");
            Console.WriteLine();
            Console.Write("Ingrese comando: ");
            string ComandoRA = Console.ReadLine();
            bool EntraRa = true;
            while (EntraRa)
            {
                if (!ComandoRA.Equals("Existente") && !ComandoRA.Equals("Nueva"))
                {
                    Console.WriteLine("Comando Erroneo intente denuevo");
                    ComandoRA = Console.ReadLine();
                }
                if (ComandoRA.Equals("Existente"))
                {
                    Console.WriteLine();
                    Console.Write("Escriba el nombre de la Raza Elegida: ");
                    string ComandoRA2 = Console.ReadLine();
                    foreach (Raza Razas in Raza_List)
                    {
                        if (Razas.Nombre == ComandoRA2)
                        {
                            PersonajeX.RazaAtributo = Razas;
                            EntraRa = false;
                            Console.WriteLine();
                        }

                    }

                }
                else if (ComandoRA.Equals("Nueva"))
                {
                    PersonajeX.RazaAtributo = CrearRaza();
                    EntraRa = false;
                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Clases Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            foreach (Clase Clases in Clase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Si Elige Clase existente Ingrese el comando Existente de lo contrario ingrese Nueva");
            Console.WriteLine();
            Console.Write("Ingrese comando: ");
            string ComandoCL = Console.ReadLine();
            bool EntraCla = true;
            while (EntraCla)
            {
                if (!ComandoCL.Equals("Existente") && !ComandoCL.Equals("Nueva"))
                {
                    Console.WriteLine("Comando Erroneo intente denuevo");
                    ComandoCL = Console.ReadLine();
                }
                if (ComandoCL.Equals("Existente"))
                {
                    Console.WriteLine();
                    Console.Write("Escriba el nombre de la Clase Elegida: ");
                    string ComandoCL2 = Console.ReadLine();
                    foreach (Clase Clases in Clase_List)
                    {
                        if (Clases.Nombre == ComandoCL2)
                        {
                            PersonajeX.ClaseAtributo = Clases;
                            EntraCla = false;
                            Console.WriteLine();
                        }
                    }

                }
                else if (ComandoCL.Equals("Nueva"))
                {
                    PersonajeX.ClaseAtributo = CrearClase();
                    EntraCla = false;
                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Caracteristicas Variables Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            ListarCaracteristicas();
            Console.WriteLine("Todas se agregaran al Personaje con los valores que usted le debe cargar a Continuacion");
            Console.WriteLine();
            foreach (Caracteristica_Variable CVLIST in Caracteristica_Variabli_List)
            {
                PersonajeX.C_VAtributoColeccion.Add( new Personaje_Caracteristica() { valor = 1, CaracteristicaV = CVLIST });
            }
            foreach(Personaje_Caracteristica PerCarac in PersonajeX.C_VAtributoColeccion)
            {
                PerCarac.valor = 0;
                Console.Write("{0}", PerCarac.CaracteristicaV.Nombre);
                Console.Write(" -> Valor: ");
                PerCarac.valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Si desea crear una nueva Caracteristica para su Personaje ingrese el comando Nueva de lo contrario ingrese Siguiente");
            Console.WriteLine();
            Console.Write("Ingrese comando: ");
            string ComandoCV = Console.ReadLine();
            Console.WriteLine();
            bool EntraCV = true;
            while (EntraCV)
            {
                if (!ComandoCV.Equals("Siguiente") && !ComandoCV.Equals("Nueva"))
                {
                    Console.WriteLine("Comando Erroneo intente denuevo");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoCV = Console.ReadLine();
                }
                if (ComandoCV.Equals("Siguiente"))
                {
                    if (Caracteristica_Variabli_List.Count == 0)
                    {
                        Console.WriteLine("No existen Caracteristicas Variables en el Sistema debe crear alguna nueva ingresando el comando Nueva");
                        Console.WriteLine();
                        Console.Write("Ingrese comando: ");
                        ComandoCV = Console.ReadLine();
                    }
                    else if (Caracteristica_Variabli_List.Count > 0)
                    {
                        EntraCV = false;
                    }

                }
                if (ComandoCV.Equals("Nueva"))
                {
                    Caracteristica_Variable aux = CrearCaracteristica();
                    PersonajeX.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { valor = 1, CaracteristicaV = aux});
                    Console.WriteLine();
                    Console.WriteLine("Escriba Siguiente si desea terminar el proceso o Nueva para agregar mas caracteristicas");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoCV = Console.ReadLine();
                    Console.WriteLine();

                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Su Raza le permite mejorar el valor de una de las siguientes caracteristica, elija una");
            Console.WriteLine();
            foreach (Personaje_Caracteristica CVLIST in PersonajeX.C_VAtributoColeccion)
            {
                Console.Write("{0}", CVLIST.CaracteristicaV.Nombre);
                Console.Write(" -> Valor: ");
                Console.WriteLine(CVLIST.valor);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Ingrese Comando: ");
            string ComandoLE = Console.ReadLine();
            foreach (Personaje_Caracteristica PersoCar in PersonajeX.C_VAtributoColeccion)
            {
                if(PersoCar.CaracteristicaV.Nombre == ComandoLE)
                {
                    PersoCar.valor = PersoCar.valor + PersonajeX.RazaAtributo.ValorPluss;
                }             
            }
            Personaje_List.Add(PersonajeX);

            return PersonajeV;
 
        }
        public void ModificarPersonaje()
        {
            IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);
            Console.Write("Elija el Personaje que desea modificar de la siguiente lista");
            Console.WriteLine();
            foreach(Personaje PerImprime in N2Personaje_List)
            {
                Console.Write(PerImprime.Nombre);
                Console.Write(" -> Nivel: ");
                Console.WriteLine(PerImprime.Nivel);
            }
            Console.WriteLine();
            Console.Write("Ingrese el Nombre del Personaje elejido: ");
            string ComandoCL = Console.ReadLine();
            Console.WriteLine();
            foreach (Personaje PerModi in N2Personaje_List)
            {
                if (ComandoCL == PerModi.Nombre)
                {
                    Console.Write("Nombre: ");
                    Console.WriteLine(PerModi.Nombre);
                    Console.Write("Id: ");
                    Console.WriteLine(PerModi.Id);
                    Console.Write("Nivel: ");
                    Console.WriteLine(PerModi.Nivel);
                    Console.Write("Fuerza: ");
                    Console.WriteLine(PerModi.Fuerza);
                    Console.Write("Destreza: ");
                    Console.WriteLine(PerModi.Destreza);
                    Console.Write("Constitucion: ");
                    Console.WriteLine(PerModi.Constitucion);
                    Console.Write("Inteligencia: ");
                    Console.WriteLine(PerModi.Inteligencia);
                    Console.Write("Sabiduria: ");
                    Console.WriteLine(PerModi.Sabiduria);
                    Console.Write("Carisma: ");
                    Console.WriteLine(PerModi.Carisma);
                    Console.Write("Raza: ");
                    Console.WriteLine(PerModi.RazaAtributo.Nombre);
                    Console.Write("Clase: ");
                    Console.WriteLine(PerModi.ClaseAtributo.Nombre);
                    Console.Write("Caracteristica Variable: ");
                    foreach (Personaje_Caracteristica CVLIST in PerModi.C_VAtributoColeccion)
                    {
                        Console.Write("{0}", CVLIST.CaracteristicaV.Nombre);
                        Console.Write(" -> Valor: ");
                        Console.WriteLine(CVLIST.valor);
                    }
                    break;
                }
            }
            bool Entra1 = true;
            while (Entra1)
            {
                int Contador = 0;

                foreach (Personaje PersonajeModi in Personaje_List)
                {
                    if (PersonajeModi.Nombre == ComandoCL)
                    {
                        Contador = Contador + 1;
                        Console.WriteLine();
                        Console.WriteLine("Selecione que desea modificar: ");
                        Console.WriteLine();
                        Console.WriteLine("Nombre");
                        Console.WriteLine("Nivel");
                        Console.WriteLine("Fuerza");
                        Console.WriteLine("Destreza");
                        Console.WriteLine("Constitucion");
                        Console.WriteLine("Inteligencia");
                        Console.WriteLine("Sabiduria");
                        Console.WriteLine("Carisma");
                        Console.WriteLine("Raza");
                        Console.WriteLine("Clase");
                        Console.WriteLine("Caracteristica");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar todo los atributos ingrese el Comando Todo");
                        Console.WriteLine();
                        Console.Write("Ingrese el comando elegido: ");
                        string ComandoCL2 = Console.ReadLine();
                        bool Entra = true;
                        Console.WriteLine();
                        while (Entra)
                        {

                            if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Nivel") && !ComandoCL2.Equals("Fuerza") && !ComandoCL2.Equals("Destreza") && !ComandoCL2.Equals("Constitucion") && !ComandoCL2.Equals("Inteligencia") && !ComandoCL2.Equals("Sabiduria") && !ComandoCL2.Equals("Carisma")
                                && !ComandoCL2.Equals("Raza") && !ComandoCL2.Equals("Clase") && !ComandoCL2.Equals("Caracteristica") && !ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine("Comando Erroneo intente denuevo");
                                ComandoCL2 = Console.ReadLine();
                            }
                            else if (ComandoCL2.Equals("Nombre"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Nombre = null;
                                Console.Write("Escriba el nuevo Nombre del Personaje: ");
                                PersonajeModi.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Nivel"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Nivel = 0;
                                Console.Write("Escriba el nuevo valor del Nilve: ");
                                PersonajeModi.Nivel = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Fuerza"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Fuerza = 0;
                                Console.Write("Escriba el nuevo valor de la Fuerza: ");
                                PersonajeModi.Fuerza = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Destreza"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Destreza = 0;
                                Console.Write("Escriba el nuevo valor de la Destreza: ");
                                PersonajeModi.Destreza = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Constitucion"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Constitucion = 0;
                                Console.Write("Escriba el nuevo valor de la Constitucion: ");
                                PersonajeModi.Constitucion = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Inteligencia"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Inteligencia = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Inteligencia: ");
                                Console.WriteLine();
                                PersonajeModi.Inteligencia = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Sabiduria"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Sabiduria = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Sabiduria: ");
                                Console.WriteLine();
                                PersonajeModi.Sabiduria = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Carisma"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Carisma = 0;
                                Console.WriteLine("Escriba el nuevo valor del Carisma: ");
                                Console.WriteLine();
                                PersonajeModi.Carisma = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Raza"))
                            {
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
                                foreach(Raza RazaElegida in Raza_List)
                                {
                                    if( ComandoEleccion == RazaElegida.Nombre)
                                    {
                                        PersonajeModi.RazaAtributo = RazaElegida;
                                    }
                                }
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Clase"))
                            {
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
                                string ComandoEleccion = Console.ReadLine();
                                foreach (Clase ClaseElegida in Clase_List)
                                {
                                    if (ComandoEleccion == ClaseElegida.Nombre)
                                    {
                                        PersonajeModi.ClaseAtributo = ClaseElegida;
                                    }
                                }
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Caracteristica"))
                            {
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
                                                Console.WriteLine("En esta instancia solo puede modificar el valor de la Caracteristica para este Presonaje");
                                                Console.WriteLine();
                                                Console.WriteLine("Si desea Modificar el nombre valla al Procedimiento modificar Caracteristica, y el nombre cambiara para cada Personaje");
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
                                        Entra = false;
                                    }
                                }
                                Console.WriteLine();
                                foreach (Personaje_Caracteristica CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                                {
                                    Console.Write(CarVarPerso.CaracteristicaV.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarVarPerso.valor);
                                }

                            }
                            else if (ComandoCL2.Equals("Todo"))
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
                                    if(Eleccion == "SI")
                                    {
                                        Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                        ComandoCL3 = Console.ReadLine();
                                    }
                                    else if(Eleccion == "NO")
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

                            }

                        }
                        Entra1 = false;
                    }
                    
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Su Personaje se a modificado con exito para serceorarse valla a ListarPersonajes");
            Console.WriteLine();
        }
        public void ListarPersonajes()
        {
            IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);
            foreach (Personaje Personajess in N2Personaje_List)
            {
                Console.Write("Nombre: ");
                Console.WriteLine(Personajess.Nombre);
                Console.Write("Id: ");
                Console.WriteLine(Personajess.Id);
                Console.Write("Nivel: ");
                Console.WriteLine(Personajess.Nivel);
                Console.Write("Fuerza: ");
                Console.WriteLine(Personajess.Fuerza);
                Console.Write("Destreza: ");
                Console.WriteLine(Personajess.Destreza);
                Console.Write("Constitucion: ");
                Console.WriteLine(Personajess.Constitucion);
                Console.Write("Inteligencia: ");
                Console.WriteLine(Personajess.Inteligencia);
                Console.Write("Sabiduria: ");
                Console.WriteLine(Personajess.Sabiduria);
                Console.Write("Carisma: ");
                Console.WriteLine(Personajess.Carisma);
                Console.Write("Raza: ");
                Console.WriteLine(Personajess.RazaAtributo.Nombre);
                Console.Write("Clase: ");
                Console.WriteLine(Personajess.ClaseAtributo.Nombre);
                Console.Write("Caracteristica Variable: ");
                Console.WriteLine();
                foreach (Personaje_Caracteristica CVLISTA in Personajess.C_VAtributoColeccion)
                {
                    Console.Write("{0}", CVLISTA.CaracteristicaV.Nombre);
                    Console.Write(" -> Valor: ");
                    Console.WriteLine(CVLISTA.valor);

                }
                Console.Write("Habilidades Especiales: ");
                Console.WriteLine();
                foreach(Habilidad_Especial HES in Personajess.H_EAtributoColeccion)
                {
                    Console.Write(HES.Nombre);
                    Console.Write(" -> Descripcion: ");
                    Console.WriteLine(HES.Descripcion);
                }
                Console.WriteLine();

            }

        }
        public void ListarPersonajesPorRaza()
        {
            foreach (Raza Razas in Raza_List)
            {
                List<Personaje> PersonajesRaza = new List<Personaje>();
                foreach (Personaje Personajes in Personaje_List)
                {
                    
                    if(Personajes.RazaAtributo == Razas)
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
                if(PersonajesClase.Count > 0)
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

        public void SubirdeNivel()
        {
            IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);
            bool EntraNivel = true;
            while (EntraNivel)
            {
                Console.WriteLine("Seleccione el Personaje al que le quiere subir de Nivel de la siguiente lista");
                Console.WriteLine();
                foreach(Personaje PeriList in Personaje_List)
                {
                    Console.Write(PeriList.Nombre);
                    Console.Write(" -> Id: ");
                    Console.WriteLine(PeriList.Id);
                    Console.WriteLine();
                }
                Console.Write("Ingrese el Nombre del Personaje elejido: ");
                string PersoElegido = Console.ReadLine();
                Console.WriteLine();
                foreach (Personaje PerNivel in N2Personaje_List)
                {
                    if (PersoElegido == PerNivel.Nombre)
                    {
                        Console.WriteLine("Como su Personaje subira de nivel puede adquirir una Habilidad Especial a eleccion de la siguiente lista");
                        Console.WriteLine();
                        foreach (Habilidad_Especial HE in PerNivel.ClaseAtributo.HE_AtributoColeccion)
                        {
                            Console.Write(HE.Nombre);
                            Console.Write(" -> Descripcion: ");
                            Console.WriteLine(HE.Descripcion);
                            Console.WriteLine();
                        }
                        Console.Write("Ingrese nombre de la habilidad elegida: ");
                        string HABELEG = Console.ReadLine();
                        foreach (Habilidad_Especial HE in PerNivel.ClaseAtributo.HE_AtributoColeccion)
                        {
                            if (HABELEG == HE.Nombre)
                            {
                                PerNivel.H_EAtributoColeccion.Add(HE);
                            }

                        }
                        if (PerNivel.Nivel % 2 == 0)
                        {
                            PerNivel.Nivel = PerNivel.Nivel + 1;
                            EntraNivel = false;
                            break;
                        }
                        else if (PerNivel.Nivel % 2 != 0 && PerNivel.Nivel != 1)
                        {
                            Console.WriteLine();
                            bool EntraGeneral = true;
                            while (EntraGeneral)
                            {
                                Console.WriteLine("Elija de la siguiente lista la Caracteristica a la que desea subir un punto de valor plus");
                                Console.WriteLine();
                                foreach (Personaje_Caracteristica CarEleshi in PerNivel.C_VAtributoColeccion)
                                {
                                    Console.Write(CarEleshi.CaracteristicaV.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarEleshi.valor);
                                }
                                Console.WriteLine();
                                Console.Write("Escriba el Nombre de la que elijio: ");
                                string ComandoCL3 = Console.ReadLine();
                                bool Entra3 = true;
                                int Contador3 = 0;
                                while (Entra3)
                                {
                                    foreach (Personaje_Caracteristica CARVARIA in PerNivel.C_VAtributoColeccion)
                                    {
                                        if (CARVARIA.CaracteristicaV.Nombre == ComandoCL3)
                                        {
                                            Contador3 = Contador3 + 1;
                                            CARVARIA.valor = CARVARIA.valor + 1;
                                            Entra3 = false;
                                            EntraGeneral = false;
                                            break;
                                        }

                                    }
                                    if (Contador3 == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Error la Caracteristica que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                        Console.WriteLine();
                                        Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                        ComandoCL3 = Console.ReadLine();
                                    }

                                }
                                PerNivel.Nivel = PerNivel.Nivel + 1;
                                break;
                                
                            }
                            EntraNivel = false;
                            Console.WriteLine();
                        }
                        break;

                    }
                    
                }
                break;
                
            }
            Console.WriteLine("Su personaje a subido con exito de Nivel");
            Console.WriteLine();

        }
        
        public Controlador()
        {
           Raza_List.Add(new Raza() { Id = 1, Nombre = "Humanos", Descripcion = "Buenos en batalla e Inteligentes pero no tan Fuertes", ValorPluss = 5 });
           Raza_List.Add(new Raza() { Id = 2, Nombre = "Ogro", Descripcion = "Poseen gran Fuerza y son abiles guerreros", ValorPluss = 1 });
           Raza_List.Add(new Raza() { Id = 3, Nombre = "Throl", Descripcion = "Poseen gran Fuerza pero poca Inteligencia", ValorPluss = 2 });
           Raza_List.Add(new Raza() { Id = 4, Nombre = "Elfo", Descripcion = "Baja constitucion y fuerza pero muy inteligentes", ValorPluss = 4 });
           Raza_List.Add(new Raza() { Id = 5, Nombre = "Gigante", Descripcion = "Muy elevada constitucion y una descomunal fuerza fisica", ValorPluss = 3 });
           Raza_List.Add(new Raza() { Id = 6, Nombre = "Hobit", Descripcion = "Iteligentes habiles y muy sabios", ValorPluss = 5 });
           Raza_List.Add(new Raza() { Id = 7, Nombre = "Mago", Descripcion = "Le sobra sabiduria y por sobre todo un gran poder magico", ValorPluss = 2 });

            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 1, Nombre = "FuerzaBrutal", Descripcion = "Le otorga al personaje una fuerza incomparable" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 2, Nombre = "Forjar", Descripcion = "Le da al personaje la habilidad de forjar armas y armaduras para la batalla" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 3, Nombre = "Improvisacion", Descripcion = "Habilidad que les permite improvisar cosas rapidamente en momentos criticos" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 4, Nombre = "BuenObservador", Descripcion = "Le permite prestar atencion a los detalles en cualquier ambito" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 5, Nombre = "RapidaEmpatia", Descripcion = "Logra que el personaje se ponga en el lugar de otro y persevir lo que siente" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 6, Nombre = "Afortunado", Descripcion = "Logra todo lo que se propone" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 7, Nombre = "AudasEspadachin", Descripcion = "le permite sobre todo a los guerreros aumentar potencial en la batalla" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 8, Nombre = "Sigiloso", Descripcion = "Logra que el Personaje se mueva precavidamente y sin levantar sospechas" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 9, Nombre = "AudasMentiroso", Descripcion = "Le sirve para escapar de situaciones usando el pequeño poder de la mentira" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 10, Nombre = "HabilidadX", Descripcion = "Poder descomunal que le da infinitas habilidades al Personaje si la consigue" });

           Clase_List.Add(new Clase() { Id = 1, Nombre = "Civiles", Descripcion = "Todos los seres e cualquier Raza que no pertenecen a una Clase especifica" });
           Clase_List.Add(new Clase() { Id = 2, Nombre = "Artilleros", Descripcion = "Se encargan de las armas y l artilleria en general en batalla" });
           Clase_List.Add(new Clase() { Id = 3, Nombre = "Escuderos", Descripcion = "Guerreros de apollo de los Caballeros en el campo de batalla" });
           Clase_List.Add(new Clase() { Id = 4, Nombre = "Caballeros", Descripcion = "Guerreros que poseen un titulo de noblesa por su valentia y fuerza" });
           Clase_List.Add(new Clase() { Id = 5, Nombre = "Guerreos de la Luz", Descripcion = "Es una clase especial de Guerreros que interviene en conflictos entre Reinos" });
           Clase_List.Add(new Clase() { Id = 6, Nombre = "Salvajes", Descripcion = "Humanos que viven escondidos en los terrorificos bosques obscuros" });

            Clase_List.ElementAt(0).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(0));
            Clase_List.ElementAt(0).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(1));
            Clase_List.ElementAt(1).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(2));
            Clase_List.ElementAt(1).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(3));
            Clase_List.ElementAt(2).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(4));
            Clase_List.ElementAt(2).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(5));
            Clase_List.ElementAt(3).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(6));
            Clase_List.ElementAt(3).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(7));
            Clase_List.ElementAt(4).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(8));
            Clase_List.ElementAt(4).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(9));

            P_C = new Caracteristica_Variable () { Id = 1, Nombre = "Navajero" };
            Caracteristica_Variabli_List.Add(P_C);

            P_C = new Caracteristica_Variable() { Id = 2, Nombre = "Destructor" };
            Caracteristica_Variabli_List.Add(P_C);

            P_C = new Caracteristica_Variable() { Id = 3, Nombre = "Golpeador" };
            Caracteristica_Variabli_List.Add(P_C);


            Personaje PersonajeK = new Personaje();
            PersonajeK.Id = 2;
            PersonajeK.Nombre = "GuerreroBlack";
            PersonajeK.Nivel = 1;
            PersonajeK.Fuerza = 4;
            PersonajeK.Destreza = 2;
            PersonajeK.Constitucion = 4;
            PersonajeK.Inteligencia = 5;
            PersonajeK.Sabiduria = 7;
            PersonajeK.Carisma = 10;
            PersonajeK.RazaAtributo = Raza_List.ElementAt(1);
            PersonajeK.ClaseAtributo = Clase_List.ElementAt(1);
            foreach(Caracteristica_Variable pERIcAR in Caracteristica_Variabli_List)
            {
                PersonajeK.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcAR , valor = 1});
            }
            Personaje_List.Add(PersonajeK);

            Personaje PersonajeL = new Personaje();
            PersonajeL.Id = 3;
            PersonajeL.Nombre = "DraigonelBarBaro";
            PersonajeL.Nivel = 7;
            PersonajeL.Fuerza = 10;
            PersonajeL.Destreza = 2;
            PersonajeL.Constitucion = 3;
            PersonajeL.Inteligencia = 5;
            PersonajeL.Sabiduria = 4;
            PersonajeL.Carisma = 1;
            PersonajeL.RazaAtributo = Raza_List.ElementAt(6);
            PersonajeL.ClaseAtributo = Clase_List.ElementAt(3);
            foreach (Caracteristica_Variable pERIcARL in Caracteristica_Variabli_List)
            {
                PersonajeL.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcARL, valor = 1 });
            }
            Personaje_List.Add(PersonajeL);

            Personaje PersonajeH = new Personaje();
            PersonajeH.Id = 4;
            PersonajeH.Nombre = "Hitmis";
            PersonajeH.Nivel = 2;
            PersonajeH.Fuerza = 4;
            PersonajeH.Destreza = 1;
            PersonajeH.Constitucion = 9;
            PersonajeH.Inteligencia = 5;
            PersonajeH.Sabiduria = 8;
            PersonajeH.Carisma = 10;
            PersonajeH.RazaAtributo = Raza_List.ElementAt(4);
            PersonajeH.ClaseAtributo = Clase_List.ElementAt(2);
            foreach (Caracteristica_Variable pERIcARH in Caracteristica_Variabli_List)
            {
                PersonajeH.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcARH, valor = 1 });
            }
            Personaje_List.Add(PersonajeH);


            




        } 

    }
}
