using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Personaje_Caracteristica
    {
        public Caracteristica CaracteristicaV { get; set; }
        public int valor { get; set; }

        public Personaje_Caracteristica()
        {
            CaracteristicaV = new Caracteristica();
        }
    }
}
