using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class Personaje_HEBL
    {
        public static int Agregar(Personaje P, Habilidad_Especial H)
        {
            int result = -1;

            result = DataAccess.Personaje_HEDA.Agregar(P, H);

            return result;
        }
    }
}
