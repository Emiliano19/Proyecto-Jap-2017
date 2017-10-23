using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Controladores
{
    public class PersonajeControlador
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }
        public RazaControlador RazaControlador { get; set; }
        public ClaseControlador ClaseControlador { get; set; }
        public Habilidad_EspecialControlador HEControlador { get; set; }
        public CaracteristicaControlador CaracteristicasControlador { get; set; }
        public SubirdeNivel SubirdeNivelControlador { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();

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
                    PersonajeX.RazaAtributo = RazaControlador.CrearRaza();
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
            Console.WriteLine();
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
                    PersonajeX.ClaseAtributo = ClaseControlador.CrearClase();
                    EntraCla = false;
                }

            }
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Se muestran las Caracteristicas Variables Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();
            CaracteristicasControlador.ListarCaracteristicas();
            Console.WriteLine("Todas se agregaran al Personaje con los valores que usted le debe cargar a Continuacion");
            Console.WriteLine();
            foreach (Caracteristica CVLIST in Caracteristica_Variabli_List)
            {
                PersonajeX.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { valor = 1, CaracteristicaV = CVLIST });
            }
            foreach (Personaje_Caracteristica PerCarac in PersonajeX.C_VAtributoColeccion)
            {
                PerCarac.valor = 0;
                Console.Write("{0}", PerCarac.CaracteristicaV.Nombre);
                Console.Write(" -> Valor: ");
                PerCarac.valor = int.Parse(Console.ReadLine());
                Console.WriteLine();
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
                    Caracteristica aux = CaracteristicasControlador.CrearCaracteristica();
                    PersonajeX.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { valor = 1, CaracteristicaV = aux });
                    Console.WriteLine();
                    Console.WriteLine("Escriba Siguiente si desea terminar el proceso o Nueva para agregar mas caracteristicas");
                    Console.WriteLine();
                    Console.Write("Ingrese comando: ");
                    ComandoCV = Console.ReadLine();
                    Console.WriteLine();

                }

            }
            /*Console.WriteLine("___________________________________________________________________________________________________________________");
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
                if (PersoCar.CaracteristicaV.Nombre == ComandoLE)
                {
                    PersoCar.valor = PersoCar.valor + PersonajeX.RazaAtributo.ValorPluss;
                }
            }*/
            Personaje_List.Add(PersonajeX);
            Console.WriteLine();

            return PersonajeV;

        }
        public void ModificarPersonaje()
        {
            IEnumerable<Personaje> N2Personaje_List = Personaje_List.OrderBy(Per => Per.Id);
            Console.Write("Elija el Personaje que desea modificar de la siguiente lista");
            Console.WriteLine();
            foreach (Personaje PerImprime in N2Personaje_List)
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
                                foreach (Raza RazaElegida in Raza_List)
                                {
                                    if (ComandoEleccion == RazaElegida.Nombre)
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
                                    if (Eleccion == "SI")
                                    {
                                        Console.Write("Escriba el Nombre de la Caracteristica que desea modificar: ");
                                        ComandoCL3 = Console.ReadLine();
                                    }
                                    else if (Eleccion == "NO")
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
            foreach (Personaje Personajess in Personaje_List)
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
                foreach (Habilidad_Especial HES in Personajess.H_EAtributoColeccion)
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

                    if (Personajes.RazaAtributo == Razas)
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
                if (PersonajesClase.Count > 0)
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

    }

}
