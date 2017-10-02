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
            int Id = Habilidad_Especial_List.Count;
            H_E = new Habilidad_Especial();
            H_E.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Habilidad Especial");
            H_E.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Habilidad Especial");
            H_E.Descripcion = Console.ReadLine();
            ListarHabilidadEspecial();
            Id = Id + 1;

            return H_E;     
        }
        public void ModificarHabilidadEspecial()
        {
         
        }
        public void ListarHabilidadEspecial()
        {
            Habilidad_Especial_List.Add(H_E);
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
            int Id = Clase_List.Count;
    
            Clase Clase = new Clase();
            Clase.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Clase");
            Clase.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Clase");
            Clase.Descripcion = Console.ReadLine();
            ListarClases();
            Id = Id + 1;

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
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ", Clases.Nombre);
                                Console.WriteLine();
                                Clases.Nombre = Console.ReadLine();
                                Entra = false;   
                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ", Clases.Nombre);
                                Console.WriteLine();
                                Clases.Descripcion = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Clases.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ", Clases.Nombre);
                                Console.WriteLine();
                                Clases.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Clases.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ", Clases.Nombre);
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
            foreach (Clase Clases in Clase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
                Console.WriteLine();
            }
        }
        public void ListarClases()
        {
            Clase_List.Add(Clase);   
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
            int Id = Raza_List.Count;
            Raza = new Raza();
            Raza.Id = Id + 1;
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
            
            ListarRazas();
            Id = Id + 1;
            Console.WriteLine();
            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }

            return Raza;    
        }
        public void ModificarRaza()
        {
            Console.Write("Escriba el Nombre de la clase que desea modificar: ");
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
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ", Razas.Nombre);
                                Console.WriteLine();
                                Razas.Nombre = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Descripcion"))
                            {
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ", Razas.Nombre);
                                Console.WriteLine();
                                Razas.Descripcion = Console.ReadLine();
                                Entra = false;

                            }
                            else if (ComandoCL2.Equals("Todo"))
                            {
                                Console.WriteLine();
                                Razas.Nombre = null;
                                Console.WriteLine("Escriba el nuevo Nombre de la Clase ", Razas.Nombre);
                                Console.WriteLine();
                                Razas.Nombre = Console.ReadLine();
                                Console.WriteLine();
                                Razas.Descripcion = null;
                                Console.WriteLine("Escriba la nueva Descripcion de la Clase ", Razas.Nombre);
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
            foreach (Raza Razas in Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }

        }
        public void ListarRazas()
        {
            Raza_List.Add(Raza);          
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
            int Id = Caracteristica_Variabli_List.Count;
            C_V = new Caracteristica_Variable();
            C_V.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Caracteristica Variable");
            Console.WriteLine();
            C_V.Nombre = Console.ReadLine();
            C_V.P_C_Valor.valor = 1;
            ListarCaracteristicas();
            Id = Id + 1;

            return C_V;

        }
        public void ModificarCaracteristica()
        {
            Console.Write("Escriba el Nombre de la caracteristica que desea modificar: ");
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
                        Console.WriteLine("Si desea modificar el nombre de la Clase ingrese el comando Nombre");
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
                                Console.WriteLine("Escriba el nuevo Nombre de la Caracteristica ", CARVARIA.Nombre);
                                Console.WriteLine();
                                CARVARIA.Nombre = Console.ReadLine();
                                Entra = false;
                            }
                            else if (ComandoCL2.Equals("Valor"))
                            {
                                Console.WriteLine();
                                CARVARIA.P_C_Valor.valor = 0;
                                Console.WriteLine("Escriba el nuevo valor de la Caracteristica ", CARVARIA.Nombre);
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

        }
        public void ListarCaracteristicas()
        {
            Caracteristica_Variabli_List.Add(C_V);
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
            int z = 1;
            Personaje = new Personaje();
            if (Personaje_List.Count == 0)
            {
                Personaje.Id = Personaje_List.Count + 1;
            }
            else if(Personaje_List.Count > 0)
            {
                foreach (Personaje Per in Personaje_List)
                {
                    if (Per.Id == z)
                    {
                        z = z + 1;
                    }
                    else if(Per.Id > z)
                    {
                        Personaje.Id = z;
                        break;
                    }
                }
            } 
            Console.WriteLine("Complete los datos de su nuevo Personaje");
            Console.WriteLine();
            Console.WriteLine("Ingrese Nombre del Personaje");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Nivel del Personaje");
            Personaje.Nivel = int.Parse(Console.ReadLine());
            while (Personaje.Nivel > 10)
            {
                Console.WriteLine("Error el Nivel no puede ser mayor a 10 intente denuevo");
                Personaje.Nivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Fuerza del Personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            while (Personaje.Fuerza > 10)
            {
                Console.WriteLine("Error la Fuerza no puede ser mayor a 10 intente denuevo");
                Personaje.Fuerza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Desztreza del Personaje");
            Personaje.Destreza = int.Parse(Console.ReadLine());
            while (Personaje.Destreza > 10)
            {
                Console.WriteLine("Error la Destreza no puede ser mayor a 10 intente denuevo");
                Personaje.Destreza = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Constitución del Personaje");
            Personaje.Constitucion = int.Parse(Console.ReadLine());
            while (Personaje.Constitucion > 10)
            {
                Console.WriteLine("Error la Constitucion no puede ser mayor a 10 intente denuevo");
                Personaje.Constitucion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Inteligencia del Personaje");
            Personaje.Inteligencia = int.Parse(Console.ReadLine());
            while (Personaje.Inteligencia > 10)
            {
                Console.WriteLine("Error la Inteligencia no puede ser mayor a 10 intente denuevo");
                Personaje.Inteligencia = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Sabiduria del Personaje");
            Personaje.Sabiduria = int.Parse(Console.ReadLine());
            while (Personaje.Sabiduria > 10)
            {
                Console.WriteLine("Error la Sabiduria no puede ser mayor a 10 intente denuevo");
                Personaje.Sabiduria = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese Carisma del Personaje");
            Personaje.Carisma = int.Parse(Console.ReadLine());
            while (Personaje.Carisma > 10)
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
            Console.WriteLine("Todas se agregaran al Personaje con valor con los valores que le debe carcar a Continuacion");
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

            Console.WriteLine("Si desea crear nueva Caracteristica para su Personaje ingrese el comando Nueva de lo contrario ingrese Siguiente");
            Console.WriteLine();
            Console.Write("Ingrese comando: ");
            string ComandoCV = Console.ReadLine();
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

            ListarPersonaje();

            Console.WriteLine();
            foreach (Personaje Personajes in Personaje_List)
            {
                Console.Write("Nombre: ");
                Console.WriteLine(Personajes.Nombre);
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
                Console.WriteLine(Personaje.RazaAtributo.Nombre);
                Console.Write("Clase: ");
                Console.WriteLine(Personaje.ClaseAtributo.Nombre);
                Console.Write("Caracteristica Variable: ");
                Console.WriteLine();
                foreach(Personaje PersonajeZ in Personaje_List)
                {
                    foreach (Caracteristica_Variable CVLIST in PersonajeZ.C_VAtributoColeccion)
                    {
                        Console.Write("{0}", CVLIST.Nombre);
                        Console.Write(" -> Valor: ");
                        Console.WriteLine(CVLIST.P_C_Valor.valor);
                    }
                }
                Console.WriteLine();
                Console.Write("Id: ");
                Console.WriteLine(Personaje.Id);
            }

            return Personaje;
 
        }
        public void ModificarPersonaje()
        {

        }
        public void ListarPersonaje()
        {
            Personaje_List.Add(Personaje);
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


           Clase_List.Add(new Clase() { Id = 1, Nombre = "Salvajes", Descripcion = "Humanos que viven escondidos en los terrorificos bosques obscuros" });
           Clase_List.Add(new Clase() { Id = 2, Nombre = "Artilleros", Descripcion = "Se encargan de las armas y l artilleria en general en batalla" });
           Clase_List.Add(new Clase() { Id = 3, Nombre = "Escuderos", Descripcion = "Guerreros de apollo de los Caballeros en el campo de batalla" });
           Clase_List.Add(new Clase() { Id = 4, Nombre = "Caballeros", Descripcion = "Guerreros que poseen un titulo de noblesa por su valentia y fuerza" });

            Personaje = new Personaje();
            Personaje.Id = 1;
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


            C_V = new Caracteristica_Variable();
            C_V.Id = 1;
            C_V.Nombre = "Navajero";
            C_V.P_C_Valor.valor = 0;
            ListarCaracteristicas();

            C_V = new Caracteristica_Variable();
            C_V.Id = 2;
            C_V.Nombre = "Destructor";
            C_V.P_C_Valor.valor = 0;
            ListarCaracteristicas();

            C_V = new Caracteristica_Variable();
            C_V.Id = 3;
            C_V.Nombre = "Golpeador";
            C_V.P_C_Valor.valor = 0;
            ListarCaracteristicas();

            foreach(Personaje Pers in Personaje_List)
            {
                Personaje.C_VAtributoColeccion.Add(C_V);
            }
        } 

    }
}
