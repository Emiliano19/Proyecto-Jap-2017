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
        public Listados Listados = new Listados();

        public void CrearHabilidadHespecial()
        {
           
            int Id = 0;
            H_E = new Habilidad_Especial();
            H_E.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Raza");
            H_E.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Raza");
            H_E.Descripcion = Console.ReadLine();
            Listados.Habilidad_Especial_List.Add(H_E);
            Id = Id + 1;
            
        }
        public void ModificarHabilidadEspecial()
        {

        }
        public void ListarHabilidadesHespeciales()
        {

        }
        public void ListarHabilidadesHespecialesPorClase()
        {

        }
        public void EliminarHabilidadEspecialPorHabilidadEspecial()
        {
         //   Listados.Habilidad_Especial_List.Remove(H_E); //Si Terminar

        }
        public Clase CrearClase()
        {
            int Id = 1;
    
            Clase Clase = new Clase();
            Clase.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Clase");
            Clase.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Clase");
            Clase.Descripcion = Console.ReadLine();
            Listados.Clase_List.Add(Clase);
            Id = Id + 1;

            return Clase;
        }
        public void ModificarClase()
        {
            string ComandoCL = Console.ReadLine();
            foreach (Clase Clases in Listados.Clase_List)
            {
                if (Clases.Nombre == ComandoCL)
                {
                    string ComandoCL2 = Console.ReadLine();
                    Console.WriteLine("Sellecione que desea modificar");
                    Console.WriteLine();
                    Console.WriteLine("Si desea modificar el nombre de la Clase ingrese el comando Nombre");
                    Console.WriteLine();
                    Console.WriteLine("Si desea Modificar Descripcion e la Raza ingrese el comando Descripcion");
                    Console.WriteLine();
                    if (ComandoCL2.Equals("Nombre"))
                    {
                        Clases.Nombre = Console.ReadLine();
                    }
                    else if (ComandoCL2.Equals("Descripcion"))
                    {
                        Clases.Descripcion = Console.ReadLine();
                    }


                }
            }
        }
        public void ListarClases()
        {
            Clase Guerrero = new Clase() { Id = 1, Nombre = "Guerrero", Descripcion = "Los guerreros poseen una gran abilidad en la lucha" };
            Listados.Clase_List.Add(Guerrero);

            foreach (Clase Clases in Listados.Clase_List)
            {
                Console.Write("{0}", Clases.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Clases.Descripcion);
                Console.WriteLine();
            }
        }
        public void EliminarClase()
        {

        }
        public Raza CrearRaza()
        {
            int Id = 7;
            Raza = new Raza();
            Raza.Id = Id + 1;
            Console.WriteLine("Ingrese Nombre de la nueva Raza");
            Raza.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Descripcion de la nueva Raza");
            Raza.Descripcion = Console.ReadLine();
            Listados.Raza_List.Add(Raza);
            Id = Id + 1;

            return Raza;
        }
        public void ModificarRaza()
        {
           
        }
        public void ListarRazas()
        {
            Listados.Raza_List.Add(new Raza() { Id = 9, Nombre = "Lobo", Descripcion = " oaerihgio" });
            Listados.Raza_List.Add(new Raza() { Id = 1, Nombre = "Humanos", Descripcion = "Buenos en batalla e Inteligentes pero no tan Fuertes" });
            Listados.Raza_List.Add(new Raza() { Id = 2, Nombre = "Ogro", Descripcion = "Poseen gran Fuerza y son abiles guerreros" });
            Listados.Raza_List.Add(new Raza() { Id = 3, Nombre = "Throl", Descripcion = "Poseen gran Fuerza pero poca Inteligencia" });
            Listados.Raza_List.Add(new Raza() { Id = 4, Nombre = "Elfo", Descripcion = "Baja constitucion y fuerza pero muy inteligentes" });
            Listados.Raza_List.Add(new Raza() { Id = 5, Nombre = "Gigante", Descripcion = "Muy elevada constitucion y una descomunal fuerza fisica" });
            Listados.Raza_List.Add(new Raza() { Id = 6, Nombre = "Hobit", Descripcion = "Iteligentes habiles y muy sabios" });
            Listados.Raza_List.Add(new Raza() { Id = 7, Nombre = "Mago", Descripcion = "Le sobra sabiduria y por sobre todo un gran poder magico" });

            foreach (Raza Razas in Listados.Raza_List)
            {
                Console.Write("{0}", Razas.Nombre);
                Console.Write(" -> Descripcion: ");
                Console.WriteLine(Razas.Descripcion);
                Console.WriteLine();
            }
        }
        public void EliminarRaza()
        {

        }

        public void CrearCaracteristica()
        {

        }
        public void ModificarCaracteristica()
        {

        }
        public void ListarCaracteristicas()
        {

        }
        public void EliminarCaracteristica()
        {

        }
        public void CrearPersonaje()
        {
            int Id = 2;
            Personaje = new Personaje();
            Personaje.Id = Id + 1;
            Console.WriteLine("Complete los datos de su nuevo Personaje");
            Console.WriteLine();
            Console.WriteLine("Ingrese Nombre del Personaje");
            Personaje.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Nivel del Personaje");
            Personaje.Nivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Fuerza del Personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Desztreza del Personaje");
            Personaje.Destreza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Constitución del Personaje");
            Personaje.Constitucion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Inteligencia del Personaje");
            Personaje.Inteligencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Sabiduria del Personaje");
            Personaje.Sabiduria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Carisma del Personaje");
            Personaje.Carisma = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ListarRazas();
            Console.WriteLine();
            Console.WriteLine(Listados.Raza_List.Count);
            
            
            Listados.Personaje_List.Add(Personaje);
            Console.WriteLine("Se muestran las Razas Existentes en el sistema a continuacion siga las instrucciones");
            Console.WriteLine();

            ListarRazas();

            Console.WriteLine();
            Console.WriteLine("Si Elige Raza existente Ingrese el comando Existente de lo contrario ingrese Nueva");
            Console.WriteLine();
            string ComandoRA = Console.ReadLine();
            if (ComandoRA.Equals("Existente"))
            {
                Console.WriteLine("Escriba el nombre de la Raza Elegida");
                Console.WriteLine();
                string ComandoRA2 = Console.ReadLine();
                foreach (Raza Razas in Listados.Raza_List)
                {
                    if (Razas.Nombre == ComandoRA2)
                    {
                        Personaje.RazaAtributo = Razas;
                    }
                }

            }
            else if (ComandoRA.Equals("Nueva"))
            {
                Personaje.RazaAtributo = CrearRaza();
            }


            Console.WriteLine("Se muestran las Clases Existentes en el sistema a continuacion siga las instrucciones");

            Console.WriteLine();
            ListarClases();
            Console.WriteLine();
            Console.WriteLine("Si Elige Clase existente Ingrese el comando Existente de lo contrario ingrese Nueva");
            Console.WriteLine();
            string ComandoCL = Console.ReadLine();

            if (ComandoCL.Equals("Existente"))
            {
                Console.WriteLine();
                Console.WriteLine("Escriba el nombre de la Clase Elegida");
                Console.WriteLine();
                string ComandoCL2 = Console.ReadLine();
                foreach (Clase Clases in Listados.Clase_List)
                {
                    if (Clases.Nombre == ComandoCL2)
                    {
                        Personaje.ClaseAtributo = Clases;
                    }
                }

            }
            else if (ComandoCL.Equals("Nueva"))
            {
                Personaje.ClaseAtributo = CrearClase();
            }

            Console.WriteLine();
            foreach (Personaje Personajes in Listados.Personaje_List)
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
            }
            
        }

        public void ModificarPersonaje()
        {

        }
        public void ListarPersonaje()
        {

        }
        public void ListarPersonajesPorRaza()
        {

        }
        public void ListarPersonajesPorClase()
        {

        }
        public void EliminarPersonaje()
        {

        }
        public void SubirdeNivel()
        {

        }
        public void Partidas()
        {
            Console.WriteLine("En la Partida 2 los Guerreros suven a nivel 4");

        }

        public Controlador()
        {
            
        }
    }
}
