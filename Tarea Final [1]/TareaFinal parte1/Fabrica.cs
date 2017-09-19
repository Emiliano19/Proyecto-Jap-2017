using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    class Fabrica
    {
        public ISistema ControladorPersonaje()
        {
            return new Controlador();
        }
    }
}
