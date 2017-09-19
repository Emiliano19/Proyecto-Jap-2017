using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fabrica Fabric = new Fabrica();
            ISistema controlador = Fabric.ControladorPersonaje();
            Console.WriteLine("IngreseComando");
            string comando = Console.ReadLine();
            while (comando != "fin")
            {
                try
                {
                    if (comando == "AltaPersonaje")
                    {
                        controlador.CrearPersonaje();
                        Console.WriteLine("Se ingreso correctamente en Personaje");
                        
                        
                    }

                    else if (comando != "AltaPersonaje")
                    {
                        Console.WriteLine("comando Erroneo vuelva a Intentar");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("A ocurridso un Error");
                }
                comando = Console.ReadLine();
            }
        }
    }
}
