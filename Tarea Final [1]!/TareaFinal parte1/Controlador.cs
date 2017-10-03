using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Controlador : ISistema
    {
        public Personaje Personaje { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica_Variable C_V { get; set; }

        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica_Variable> Caracteristica_Variabli_List = new List<Caracteristica_Variable>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();
      //public List<Personaje_Caracteristica> PersoCara_List = new List<Personaje_Caracteristica>();

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
            Console.WriteLine("Ingrese Nombre de la nueva Habilidad Especial");
            H_E.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Habilidad Especial");
            H_E.Descripcion = Console.ReadLine();
            Habilidad_Especial_List.Add(H_E);

            return H_E;     
        }
        public void ModificarHabilidadEspecial()
        {
            Console.Write("Escriba el Nombre de la Habilidad Especiale que desea modificar: ");
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
                                Console.WriteLine("Escriba el nuevo Nombre de la Habilidad Especial");
                                Console.WriteLine();
                                HE.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoHE2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                HE.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Habilidad Especial");
                                Console.WriteLine();
                                HE.Descripcion = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoHE2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                HE.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ", HE.Nombre);
                                Console.WriteLine();
                                HE.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                HE.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Habilidad Especial");
                                Console.WriteLine();
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
            ListarHabilidadesEspeciales();
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
                List<Habilidad_Especial> HEClase = new List<Habilidad_Especial>();
                foreach (Habilidad_Especial HE in Habilidad_Especial_List)
                {

                    if (HE.ClaseAtributo == Clases)
                    {
                        Habilidad_Especial_List.Add(HE);
                    }

                }
                if (Habilidad_Especial_List.Count > 0)
                {
                    Console.WriteLine(Clases.Nombre);
                }
                foreach (Habilidad_Especial HabEspec in HEClase)
                {
                    Console.Write("{0}", HabEspec.Nombre);
                    Console.Write("-> Descripcion: ");
                    Console.WriteLine(HabEspec.Descripcion);
                }
                Console.WriteLine();
                HEClase = new List<Habilidad_Especial>();

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
            Console.WriteLine("Ingrese Nombre de la nueva Clase");
            Clase.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Clase");
            Clase.Descripcion = Console.ReadLine();
            Clase_List.Add(Clase);

            return Clase;
        }
        public void ModificarClase()
        {
            Console.Write("Escriba el Nombre de la clase que desea modificar: ");
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
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ");
                                Console.WriteLine();
                                Clases.Nombre = Console.ReadLine();
                                Entra = false;   
                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ");
                                Console.WriteLine();
                                Clases.Descripcion = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Clases.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ");
                                Console.WriteLine();
                                Clases.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ");
                                Console.WriteLine();
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
            ListarClases();
        }
        public void ListarClases()
        {
            IEnumerable<Clase> NClase_List = Clase_List.OrderBy(Clas => Clas.Id);

            foreach (Clase Clases in Clase_List)
            {
                Console.WriteLine();
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
            foreach (Clase Clases in Clase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Clase que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Clase Clases in Clase_List)
            {
                if (Clases.Nombre == Comando)
                {
                    Clase_List.Remove(Clases);
                    break;
                }
            }

            foreach (Clase Clases in Clase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
                Console.WriteLine();
            }

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
            Console.WriteLine("Ingrese Nombre de la nueva Raza");
            Raza.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Raza");
            Raza.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del plus que desea sumarle a la caracteristica elegida");
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
            Console.Write("Escriba el Nombre de la Raza que desea modificar: ");
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
                                Console.WriteLine("Escriba el nuevo Nombre de la Raza ");
                                Console.WriteLine();
                                Razas.Nombre = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Raza");
                                Console.WriteLine();
                                Razas.Descripcion = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Razas.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Raza");
                                Console.WriteLine();
                                Razas.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Raza");
                                Console.WriteLine();
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
            ListarRazas();

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
            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Raza que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Raza Razas in Raza_List)
            {
                if (Razas.Nombre == Comando)
                {
                    Raza_List.Remove(Razas);
                    break;
                }
            }

            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }
        }

        public Caracteristica_Variable CrearCaracteristica()
        {
            IEnumerable<Caracteristica_Variable> NCaracteristica_Variable_List = Caracteristica_Variabli_List.OrderBy(Car => Car.Id);
            int z = 1;
            C_V = new Caracteristica_Variable();
            if (Caracteristica_Variabli_List.Count == 0)
            {
                C_V.Id = 1;
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
                        C_V.Id = z;
                        break;
                    }
                }
                if (C_V.Id == 0)
                {
                    C_V.Id = Caracteristica_Variabli_List.Count + 1;
                }
            }
            Console.WriteLine("Ingrese Nombre de la nueva Caracteristica Variable");
            Console.WriteLine();
            C_V.Nombre = Console.ReadLine();
            C_V.P_C_Valor.valor = 1;
            Caracteristica_Variabli_List.Add(C_V);

            return C_V;

        }
        public void ModificarCaracteristica()
        {
            Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
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
                        Console.WriteLine("Selecione que desea modificar");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar el nombre de la Caracteristica ingrese el comando Nombre");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar el valor de la Caracteristica ingrese Valor");
                        string ComandoCL2 = Console.ReadLine();
                        bool Entra = true;
                        while (Entra)
                        {

                            if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Valor") && !ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine("Comando Erroneo intente denuevo");
                                ComandoCL2 = Console.ReadLine();
                            }
                            if (ComandoCL2.Equals("Nombre"))
                            {
                                Console.WriteLine();
                                CARVARIA.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ");
                                Console.WriteLine();
                                CARVARIA.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Valor"))
                            {
                                Console.WriteLine();
                                CARVARIA.P_C_Valor.valor = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Caracteristica ");
                                Console.WriteLine();
                                CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                CARVARIA.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ", CARVARIA.Nombre);
                                Console.WriteLine();
                                CARVARIA.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                CARVARIA.P_C_Valor.valor = 0;
                                Console.WriteLine("Escriba el valor de la nueva Caracteristica ", CARVARIA.Nombre);
                                Console.WriteLine();
                                CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
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
            ListarCaracteristicas();

        }
        public void ListarCaracteristicas()
        {
            IEnumerable<Caracteristica_Variable> NCaracteristica_Variable_List = Caracteristica_Variabli_List.OrderBy(Car => Car.Id);

            foreach (Caracteristica_Variable CV in NCaracteristica_Variable_List)
            {
                Console.Write(CV.Nombre);
                Console.Write(" -> Valor: ");
                Console.Write("No asignado");
                Console.Write(" -> Id: ");
                Console.WriteLine(CV.Id);
            }
        }
        public void EliminarCaracteristica()
        {
            Console.WriteLine("Lista de las Caracteristicas Variables existentes en el sistema");
            Console.WriteLine();
            foreach (Caracteristica_Variable CV in Caracteristica_Variabli_List)
            {
                Console.Write("{0}", CV.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(CV.P_C_Valor.valor);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Escriba el nombre de la Caracteristica Variable que desea Eliminar");
            Console.WriteLine();
            string Comando = Console.ReadLine();
            foreach (Caracteristica_Variable CV in Caracteristica_Variabli_List)
            {
                if (CV.Nombre == Comando)
                {
                    Caracteristica_Variabli_List.Remove(CV);
                    break;
                }
            }
            foreach (Caracteristica_Variable CV in Caracteristica_Variabli_List)
            {
                Console.Write("{0}", CV.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(CV.P_C_Valor.valor);
                Console.WriteLine();
            }

        }
        public Personaje CrearPersonaje()
        {
            IEnumerable<Personaje> NPersonaje_List = Personaje_List.OrderBy(Per => Per.Id);
            int z = 1;
            Personaje = new Personaje();
            if (Personaje_List.Count == 0)
            {
                Personaje.Id = 1;
            }
            else if(Personaje_List.Count > 0)
            {
                foreach (Personaje Per in NPersonaje_List)
                {
                    if (Per.Id == z)
                    {
                        z = z + 1;
                    }
                    else if(Per.Id != z)
                    {
                        Personaje.Id = z;
                        break;
                    }
                }
                if(Personaje.Id == 0)
                {
                    Personaje.Id = Personaje_List.Count + 1;
                }
            } 
            Console.WriteLine("Complete los datos de su nuevo Personaje");
            Console.WriteLine();
            Console.WriteLine("Ingrese Nombre del Personaje");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Nivel del Personaje");
            Personaje.Nivel = int.Parse(Console.ReadLine());
            while (Personaje.Nivel > 10 || Personaje.Nivel < 0)
            {
                Console.WriteLine("Error el Nivel no puede ser mayor a 10 intente denuevo");
                Personaje.Nivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Fuerza del Personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            while (Personaje.Fuerza > 10 || Personaje.Fuerza < 0)
            {
                Console.WriteLine("Error la Fuerza no puede ser mayor a 10 intente denuevo");
                Personaje.Fuerza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Desztreza del Personaje");
            Personaje.Destreza = int.Parse(Console.ReadLine());
            while (Personaje.Destreza > 10 || Personaje.Destreza < 0)
            {
                Console.WriteLine("Error la Destreza no puede ser mayor a 10 intente denuevo");
                Personaje.Destreza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Constitución del Personaje");
            Personaje.Constitucion = int.Parse(Console.ReadLine());
            while (Personaje.Constitucion > 10 || Personaje.Constitucion < 0)
            {
                Console.WriteLine("Error la Constitucion no puede ser mayor a 10 intente denuevo");
                Personaje.Constitucion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Inteligencia del Personaje");
            Personaje.Inteligencia = int.Parse(Console.ReadLine());
            while (Personaje.Inteligencia > 10 || Personaje.Inteligencia < 0)
            {
                Console.WriteLine("Error la Inteligencia no puede ser mayor a 10 intente denuevo");
                Personaje.Inteligencia = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Sabiduria del Personaje");
            Personaje.Sabiduria = int.Parse(Console.ReadLine());
            while (Personaje.Sabiduria > 10 || Personaje.Sabiduria < 0)
            {
                Console.WriteLine("Error la Sabiduria no puede ser mayor a 10 intente denuevo");
                Personaje.Sabiduria = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Carisma del Personaje");
            Personaje.Carisma = int.Parse(Console.ReadLine());
            while (Personaje.Carisma > 10 || Personaje.Carisma < 0)
            {
                Console.WriteLine("Error el Carisma no puede ser mayor a 10 intente denuevo");
                Personaje.Carisma = int.Parse(Console.ReadLine());
            }

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
            while(EntraRa)
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
                            Personaje.RazaAtributo = Razas;
                            EntraRa = false;
                            Console.WriteLine();
                        }
                        
                    }

                }
                else if (ComandoRA.Equals("Nueva"))
                {
                    Personaje.RazaAtributo = CrearRaza();
                    EntraRa = false;
                }
                
            }

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
                            Personaje.ClaseAtributo = Clases;
                            EntraCla = false;
                            Console.WriteLine();
                        }
                    }
                    
                }
                else if (ComandoCL.Equals("Nueva"))
                {
                    Personaje.ClaseAtributo = CrearClase();
                    EntraCla = false;

                }
               
            }

            Console.WriteLine();
            Console.WriteLine("Se muestran las Caracteristicas Variables Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            foreach (Caracteristica_Variable CVLIST in Caracteristica_Variabli_List)
            {
                Console.Write("{0}", CVLIST.Nombre);
                Console.Write(" -> Valor: ");
                Console.WriteLine(CVLIST.P_C_Valor.valor);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Todas se agregaran al Personaje con los valores que le debe cargar a Continuacion");
            Console.WriteLine();
            foreach (Caracteristica_Variable CVLIST in Caracteristica_Variabli_List)
            {
                Console.Write("{0}", CVLIST.Nombre);
                CVLIST.P_C_Valor.valor = 0;
                Console.Write(" -> Valor: ");
                CVLIST.P_C_Valor.valor = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Personaje.C_VAtributoColeccion.Add(CVLIST);
               
            }
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
                    else if(Caracteristica_Variabli_List.Count > 0)
                    {
                        EntraCV = false;
                    }

                }
                if (ComandoCV.Equals("Nueva"))
                {
                    Personaje.C_VAtributo = CrearCaracteristica();
                    Personaje.C_VAtributoColeccion.Add(Personaje.C_VAtributo);
                    foreach (Personaje Personajes in Personaje_List)
                    {
                        Personajes.C_VAtributoColeccion.Add(Personaje.C_VAtributo);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Escriba Siguiente si desea terminar el proceso o Nueva para agregar mas caracteristicas");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoCV = Console.ReadLine();

                }   

            }
            Console.WriteLine();
            Console.WriteLine("Su Raza le permite mejorar el valor de una de las siguientes caracteristica, elija una");
            Console.WriteLine();
            foreach (Caracteristica_Variable CVLIST in Personaje.C_VAtributoColeccion)
            {
                Console.Write("{0}", CVLIST.Nombre);
                Console.Write(" -> Valor: ");
                Console.WriteLine(CVLIST.P_C_Valor.valor);
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.Write("Ingrese Comando: ");
            string ComandoLE = Console.ReadLine();
            foreach (Caracteristica_Variable Personajes in Personaje.C_VAtributoColeccion)
            {
                if(Personajes.Nombre == ComandoLE)
                {
                    Personajes.P_C_Valor.valor = Personajes.P_C_Valor.valor + Personaje.RazaAtributo.ValorPluss;
                    break;
                }
               
            }

            Personaje_List.Add(Personaje);
           /* IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);
            
            Console.WriteLine();
            foreach (Personaje Personajes in N2Personaje_List)
            {
                Console.Write("Nombre: ");
                Console.WriteLine(Personajes.Nombre);
                Console.Write("Id: ");
                Console.WriteLine(Personajes.Id);
                Console.Write("Nivel: ");
                Console.WriteLine(Personajes.Nivel);
                Console.Write("Fuerza: ");
                Console.WriteLine(Personajes.Fuerza);
                Console.Write("Destreza: ", Personajes.Destreza);
                Console.WriteLine(Personajes.Destreza);
                Console.Write("Constitucion: ");
                Console.WriteLine(Personajes.Constitucion);
                Console.Write("Inteligencia: ");
                Console.WriteLine(Personajes.Inteligencia);
                Console.Write("Sabiduria: ");
                Console.WriteLine(Personajes.Sabiduria);
                Console.Write("Carisma: ");
                Console.WriteLine(Personajes.Carisma);
                Console.Write("Raza: ");
                Console.WriteLine(Personajes.RazaAtributo.Nombre);
                Console.Write("Clase: ");
                Console.WriteLine(Personajes.ClaseAtributo.Nombre);
                Console.Write("Caracteristica Variable: ");
                Console.WriteLine();
                foreach (Caracteristica_Variable CVLIST in Personajes.C_VAtributoColeccion)
                {
                    Console.Write("{0}", CVLIST.Nombre);
                    Console.Write(" -> Valor: ");
                    Console.WriteLine(CVLIST.P_C_Valor.valor);
                    
                }
                Console.WriteLine();

            }*/

            return Personaje;
 
        }
        public void ModificarPersonaje()
        {
            Console.Write("Elija el Personaje que desea modificar de la siguiente lista");
            Console.WriteLine();
            foreach(Personaje PerImprime in Personaje_List)
            {
                Console.Write(PerImprime.Nombre);
                Console.Write(" -> Nivel: ");
                Console.WriteLine(PerImprime.Nivel);
            }
            Console.WriteLine();
            Console.Write("Ingrese el Nombre del Personaje elejido: ");
            string ComandoCL = Console.ReadLine();
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
                        Console.WriteLine();
                        Console.WriteLine("Raza");
                        Console.WriteLine("Clase");
                        Console.WriteLine("Caracteristicas Variables");
                        Console.WriteLine();
                        Console.WriteLine("Si desea modificar todo los atributos ingrese el Comando Todo");
                        Console.WriteLine();
                        Console.Write("Ingrese el comando elegido: ");
                        string ComandoCL2 = Console.ReadLine();
                        bool Entra = true;
                        while (Entra)
                        {

                            if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Nivel") && !ComandoCL2.Equals("fuerza") && !ComandoCL2.Equals("Destreza") && !ComandoCL2.Equals("Constitucion") && !ComandoCL2.Equals("Inteligencia") && !ComandoCL2.Equals("Sabiduria") && !ComandoCL2.Equals("Carisma")
                                && !ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine("Comando Erroneo intente denuevo");
                                ComandoCL2 = Console.ReadLine();
                            }
                            if (ComandoCL2.Equals("Nombre"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre del Personaje ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Nivel"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Nivel = 0;
                                Console.WriteLine("Escriba el nuevo valor del Nilve de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Nivel = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Fuerza"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Fuerza = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Fuerza de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Fuerza = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Destreza"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Destreza = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Destreza de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Destreza = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Constitucion"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Constitucion = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Constitucion de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Constitucion = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Inteligencia"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Inteligencia = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Inteligencia de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Inteligencia = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Sabiduria"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Sabiduria = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Sabiduria de ", PersonajeModi.Nombre);
                                Console.WriteLine();
                                PersonajeModi.Sabiduria = int.Parse(Console.ReadLine());
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Carisma"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Carisma = 0;
                                Console.WriteLine("Escriba el nuevo valor del Carisma de ", PersonajeModi.Nombre);
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
                                Console.WriteLine("Escriba el Nombre de la Raza elegida: ");
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
                                Console.WriteLine("Escriba el Nombre de la Clase elegida: ");
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
                                Console.WriteLine("Caracteristicas Existentes en la coleccion de caracteristicas del actual Personaje");
                                Console.WriteLine();
                                foreach (Caracteristica_Variable CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                                {
                                    Console.Write(CarVarPerso.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarVarPerso.P_C_Valor.valor);

                                }
                                Console.WriteLine();
                                Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                string ComandoCL3 = Console.ReadLine();
                                bool Entra3 = true;
                                while (Entra3)
                                {
                                    int Contador3 = 0;

                                    foreach (Caracteristica_Variable CARVARIA in Caracteristica_Variabli_List)
                                    {

                                        if (CARVARIA.Nombre == ComandoCL)
                                        {
                                            Contador3 = Contador3 + 1;
                                            Console.WriteLine();
                                            Console.WriteLine("Selecione que desea modificar");
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea modificar el nombre de la Caracteristica ingrese el comando Nombre");
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea modificar el valor de la Caracteristica ingrese Valor");
                                            string ComandoCL4 = Console.ReadLine();
                                            bool Entra4 = true;
                                            while (Entra4)
                                            {

                                                if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Valor") && !ComandoCL2.Equals("Todo"))
                                                {
                                                    Console.WriteLine("Comando Erroneo intente denuevo");
                                                    ComandoCL2 = Console.ReadLine();
                                                }
                                                if (ComandoCL2.Equals("Nombre"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = null;
                                                    Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ");
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = Console.ReadLine();
                                                    Entra4 = false;
                                                }
                                                else if (ComandoCL2.Equals("Valor"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = 0;
                                                    Console.WriteLine("Escriba el nuevo valor de la Caracteristica ");
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
                                                    Entra4 = false;
                                                }
                                                else if (ComandoCL2.Equals("Todo"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = null;
                                                    Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ", CARVARIA.Nombre);
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = Console.ReadLine();
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = 0;
                                                    Console.WriteLine("Escriba el valor de la nueva Caracteristica ", CARVARIA.Nombre);
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
                                                    Entra4 = false;
                                                }

                                            }
                                            Entra3 = false;
                                        }

                                    }

                                    if (Contador3 == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Error la Clase que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                        Console.WriteLine();
                                        Console.Write("Escriba el Nombre de la clase que desea modificar: ");
                                        ComandoCL = Console.ReadLine();
                                    }

                                }
                                Console.WriteLine();
                                foreach (Caracteristica_Variable CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                                {
                                    Console.Write(CarVarPerso.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarVarPerso.P_C_Valor.valor);

                                }
                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                PersonajeModi.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre del Personaje ", PersonajeModi.Nombre);
                                PersonajeModi.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                PersonajeModi.Nivel = 0;
                                Console.WriteLine("Escriba el nuevo valor del Nilve de ", PersonajeModi.Nombre);
                                PersonajeModi.Nivel = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Fuerza = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Fuerza de ", PersonajeModi.Nombre);
                                PersonajeModi.Fuerza = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Destreza = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Destreza de ", PersonajeModi.Nombre);
                                PersonajeModi.Destreza = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Constitucion = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Constitucion de ", PersonajeModi.Nombre);
                                PersonajeModi.Constitucion = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Inteligencia = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Inteligencia de ", PersonajeModi.Nombre);
                                PersonajeModi.Inteligencia = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Sabiduria = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Sabiduria de ", PersonajeModi.Nombre);
                                PersonajeModi.Sabiduria = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                PersonajeModi.Carisma = 0;
                                Console.WriteLine("Escriba el nuevo valor del Carisma de ", PersonajeModi.Nombre);
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
                                foreach (Caracteristica_Variable CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                                {
                                    Console.Write(CarVarPerso.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarVarPerso.P_C_Valor.valor);

                                }
                                Console.WriteLine();
                                Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                string ComandoCL3 = Console.ReadLine();
                                bool Entra3 = true;
                                while (Entra3)
                                {
                                    int Contador3 = 0;

                                    foreach (Caracteristica_Variable CARVARIA in Caracteristica_Variabli_List)
                                    {

                                        if (CARVARIA.Nombre == ComandoCL)
                                        {
                                            Contador3 = Contador3 + 1;
                                            Console.WriteLine();
                                            Console.WriteLine("Selecione que desea modificar");
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea modificar el nombre de la Caracteristica ingrese el comando Nombre");
                                            Console.WriteLine();
                                            Console.WriteLine("Si desea modificar el valor de la Caracteristica ingrese Valor");
                                            string ComandoCL4 = Console.ReadLine();
                                            bool Entra4 = true;
                                            while (Entra4)
                                            {

                                                if (!ComandoCL2.Equals("Nombre") && !ComandoCL2.Equals("Valor") && !ComandoCL2.Equals("Todo"))
                                                {
                                                    Console.WriteLine("Comando Erroneo intente denuevo");
                                                    ComandoCL2 = Console.ReadLine();
                                                }
                                                if (ComandoCL2.Equals("Nombre"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = null;
                                                    Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ");
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = Console.ReadLine();
                                                    Entra4 = false;
                                                }
                                                else if (ComandoCL2.Equals("Valor"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = 0;
                                                    Console.WriteLine("Escriba el nuevo valor de la Caracteristica ");
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
                                                    Entra4 = false;
                                                }
                                                else if (ComandoCL2.Equals("Todo"))
                                                {
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = null;
                                                    Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ", CARVARIA.Nombre);
                                                    Console.WriteLine();
                                                    CARVARIA.Nombre = Console.ReadLine();
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = 0;
                                                    Console.WriteLine("Escriba el valor de la nueva Caracteristica ", CARVARIA.Nombre);
                                                    Console.WriteLine();
                                                    CARVARIA.P_C_Valor.valor = int.Parse(Console.ReadLine());
                                                    Entra4 = false;
                                                }

                                            }
                                            Entra3 = false;
                                        }

                                    }

                                    if (Contador3 == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Error la Clase que a elegido no se encuentra en el Sistema, serciorese de haber ingresado bien el nombre");
                                        Console.WriteLine();
                                        Console.Write("Escriba el Nombre de la clase que desea modificar: ");
                                        ComandoCL = Console.ReadLine();
                                    }

                                }
                                Console.WriteLine();
                                foreach (Caracteristica_Variable CarVarPerso in PersonajeModi.C_VAtributoColeccion)
                                {
                                    Console.Write(CarVarPerso.Nombre);
                                    Console.Write(" -> Valor: ");
                                    Console.WriteLine(CarVarPerso.P_C_Valor.valor);

                                }


                            }

                        }
                        Entra1 = false;
                    }

                    Console.Write("Nombre: ");
                    Console.WriteLine(PersonajeModi.Nombre);
                    Console.Write("Id: ");
                    Console.WriteLine(PersonajeModi.Id);
                    Console.Write("Nivel: ");
                    Console.WriteLine(PersonajeModi.Nivel);
                    Console.Write("Fuerza: ");
                    Console.WriteLine(PersonajeModi.Fuerza);
                    Console.Write("Destreza: ");
                    Console.WriteLine(PersonajeModi.Destreza);
                    Console.WriteLine(PersonajeModi.Destreza);
                    Console.Write("Constitucion: ");
                    Console.WriteLine(PersonajeModi.Constitucion);
                    Console.Write("Inteligencia: ");
                    Console.WriteLine(PersonajeModi.Inteligencia);
                    Console.Write("Sabiduria: ");
                    Console.WriteLine(PersonajeModi.Sabiduria);
                    Console.Write("Carisma: ");
                    Console.WriteLine(PersonajeModi.Carisma);
                    Console.Write("Raza: ");
                    Console.WriteLine(PersonajeModi.RazaAtributo.Nombre);
                    Console.Write("Clase: ");
                    Console.WriteLine(PersonajeModi.ClaseAtributo.Nombre);
                    Console.Write("Caracteristica Variable: ");
                    Console.WriteLine();
                    foreach (Caracteristica_Variable CVLIST in Personaje.C_VAtributoColeccion)
                    {
                        Console.Write("{0}", CVLIST.Nombre);
                        Console.Write(" -> Valor: ");
                        Console.WriteLine(CVLIST.P_C_Valor.valor);
                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Exelente se a modificado su Personaje y no an avido Errores");

        }

        public void ListarPersonajes()
        {
            IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);

            foreach (Personaje Personajes in N2Personaje_List)
            {
                Console.Write("Nombre: ");
                Console.WriteLine(Personajes.Nombre);
                Console.Write("Id: ");
                Console.WriteLine(Personajes.Id);
                Console.Write("Nivel: ");
                Console.WriteLine(Personajes.Nivel);
                Console.Write("Fuerza: ");
                Console.WriteLine(Personajes.Fuerza);
                Console.Write("Destreza: ", Personajes.Destreza);
                Console.WriteLine(Personajes.Destreza);
                Console.Write("Constitucion: ");
                Console.WriteLine(Personajes.Constitucion);
                Console.Write("Inteligencia: ");
                Console.WriteLine(Personajes.Inteligencia);
                Console.Write("Sabiduria: ");
                Console.WriteLine(Personajes.Sabiduria);
                Console.Write("Carisma: ");
                Console.WriteLine(Personajes.Carisma);
                Console.Write("Raza: ");
                Console.WriteLine(Personajes.RazaAtributo.Nombre);
                Console.Write("Clase: ");
                Console.WriteLine(Personajes.ClaseAtributo.Nombre);
                Console.Write("Caracteristica Variable: ");
                Console.WriteLine();
                foreach (Caracteristica_Variable CVLIST in Personajes.C_VAtributoColeccion)
                {
                    Console.Write("{0}", CVLIST.Nombre);
                    Console.Write(" -> Valor: ");
                    Console.WriteLine(CVLIST.P_C_Valor.valor);

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

        }

        public void SubirdeNivel()
        {

        }
        public void SimulaciondelJuego()
        {
            Console.WriteLine("En la Partida 2 los Guerreros suven a nivel 4");

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
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 8, Nombre = "Sigiloso", Descripcion = "Logra que el Personaje se mueva precavidamente y sin destacar sospecha por donde se mueva" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 9, Nombre = "AudasMentiroso", Descripcion = "Le sirve para escapar de situaciones usando el pequeño poder de la mentira" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() {Id = 10, Nombre = "HabilidadX", Descripcion = "Poder descomunal que le da infinitas habilidades al Personaje si la consigue" });


            Clase_List.Add(new Clase() { Id = 1, Nombre = "Salvajes", Descripcion = "Humanos que viven escondidos en los terrorificos bosques obscuros" });
           Clase_List.Add(new Clase() { Id = 2, Nombre = "Artilleros", Descripcion = "Se encargan de las armas y l artilleria en general en batalla" });
           Clase_List.Add(new Clase() { Id = 3, Nombre = "Escuderos", Descripcion = "Guerreros de apollo de los Caballeros en el campo de batalla" });
           Clase_List.Add(new Clase() { Id = 4, Nombre = "Caballeros", Descripcion = "Guerreros que poseen un titulo de noblesa por su valentia y fuerza" });

            Personaje = new Personaje();
            Personaje.Id = 2;
            Personaje.Nombre = "PersonajeK";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(1);
            Personaje.ClaseAtributo = Clase_List.ElementAt(1);
            Personaje_List.Add(Personaje);

            Personaje = new Personaje();
            Personaje.Id = 3;
            Personaje.Nombre = "PersonajeH";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(2);
            Personaje.ClaseAtributo = Clase_List.ElementAt(3);
            Personaje_List.Add(Personaje);

            Personaje = new Personaje();
            Personaje.Id = 1;
            Personaje.Nombre = "PersonajeL";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(5);
            Personaje.ClaseAtributo = Clase_List.ElementAt(1);
            Personaje_List.Add(Personaje);

            Personaje = new Personaje();
            Personaje.Id = 5;
            Personaje.Nombre = "PersonajeI";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(1);
            Personaje.ClaseAtributo = Clase_List.ElementAt(0);
            Personaje_List.Add(Personaje);

            Personaje = new Personaje();
            Personaje.Id = 4;
            Personaje.Nombre = "PersonajeQ";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(6);
            Personaje.ClaseAtributo = Clase_List.ElementAt(3);
            Personaje_List.Add(Personaje);


            Personaje = new Personaje();
            Personaje.Id = 7;
            Personaje.Nombre = "PersonajeP";
            Personaje.Nivel = 1;
            Personaje.Fuerza = 5;
            Personaje.Destreza = 3;
            Personaje.Constitucion = 4;
            Personaje.Inteligencia = 5;
            Personaje.Sabiduria = 7;
            Personaje.Carisma = 10;
            Personaje.RazaAtributo = Raza_List.ElementAt(5);
            Personaje.ClaseAtributo = Clase_List.ElementAt(2);
            Personaje_List.Add(Personaje);



            C_V = new Caracteristica_Variable();
            C_V.Id = 1;
            C_V.Nombre = "Navajero";
            C_V.P_C_Valor.valor = 0;
            Caracteristica_Variabli_List.Add(C_V);

            C_V = new Caracteristica_Variable();
            C_V.Id = 2;
            C_V.Nombre = "Destructor";
            C_V.P_C_Valor.valor = 0;
            Caracteristica_Variabli_List.Add(C_V);

            C_V = new Caracteristica_Variable();
            C_V.Id = 3;
            C_V.Nombre = "Golpeador";
            C_V.P_C_Valor.valor = 0;
            Caracteristica_Variabli_List.Add(C_V);

            foreach (Personaje Pers in Personaje_List)
            {
                Pers.C_VAtributoColeccion.Add(C_V);
            }
        } 

    }
}
