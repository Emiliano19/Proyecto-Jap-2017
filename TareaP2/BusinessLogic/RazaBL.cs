using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class RazaBL
    {
        public static int Add(Raza Raza)
        {
            int result = -1;

            result = DataAccess.RazaDA.Agregar(Raza);

            return result;
        }

        public static List<Raza> Listar()
        {
            List<Raza> result = null;

            result = DataAccess.RazaDA.Listar();

            return result;
        }

        public static Raza Obtener(int id)
        {
            return DataAccess.RazaDA.Obtener(id);
        }

        public static int Modificar(Raza Raza)
        {
            int result = -1;

            result = DataAccess.RazaDA.Modificar(Raza);

            return result;
        }

        public static int Eliminar(Raza Raza)
        {
            int result = -1;

            result = DataAccess.RazaDA.Eliminar(Raza);

            return result;
        }

    }
}
