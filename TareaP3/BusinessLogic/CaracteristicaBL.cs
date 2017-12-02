using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class CaracteristicaBL
    {
        public static int Agregar(Caracteristica Caracteristica)
        {
            int result = -1;

            result = DataAccess.CaracteristicaDA.Agregar(Caracteristica);

            return result;
        }

        public static List<Caracteristica> Listar()
        {
            List<Caracteristica> result = null;

            result = DataAccess.CaracteristicaDA.Listar();

            return result;
        }

        public static Caracteristica Obtener(int id)
        {
            return DataAccess.CaracteristicaDA.Obtener(id);
        }

        public static int Modificar(Caracteristica Caracteristica)
        {
            int result = -1;

            result = DataAccess.CaracteristicaDA.Modificar(Caracteristica);

            return result;
        }

        public static int Eliminar(int IdCar)
        {
            int result = -1;

            result = DataAccess.CaracteristicaDA.Eliminar(IdCar);

            return result;
        }
    }
}
