using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    class Personaje_CaracteristicaBL
    {
        public static Personaje_Caracteristica Obtener(int id)
        {
            return DataAccess.Personaje_CaracteristicaDA.Obtener(id);
        }
    }
}
