using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class Personaje_CaracteristicaBL
    {
        public static int Agregar(int IdP, int IdC, int Valor)
        {
            int result = -1;

            result = DataAccess.Personaje_CaracteristicaDA.Agregar(IdP, IdC, Valor);

            return result;
        }

        public static Personaje_Caracteristica Obtener(int IdP, int IdC)
        {
            return DataAccess.Personaje_CaracteristicaDA.Obtener(IdP, IdC);
        }

      /*  public static List<Personaje_Caracteristica> Listar()
        {
            List<Personaje_Caracteristica> result = null;

            result = DataAccess.Personaje_CaracteristicaDA.Listar();

            return result;
        }*/

        public static int Modificar(int IdP, int IdC, int Valor)
        {
            int result = -1;

            result = DataAccess.Personaje_CaracteristicaDA.Modificar(IdP, IdC, Valor);

            return result;
        }

        public static int Eliminar(int IdP, int IdC)
        {
            int result = -1;

            result = DataAccess.Personaje_CaracteristicaDA.Eliminar(IdP, IdC);

            return result;
        }
    }
}
