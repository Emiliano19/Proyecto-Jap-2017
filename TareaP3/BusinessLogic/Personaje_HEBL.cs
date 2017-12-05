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
        public static int Agregar(int IdP, int IdH)
        {
            int result = -1;

            result = DataAccess.Personaje_HEDA.Agregar(IdP, IdH);

            return result;
        }

        public static List<Personaje_HE> Listar()
        {
            List<Personaje_HE> result = null;

            result = DataAccess.Personaje_HEDA.Listar();

            return result;
        }

        public static Personaje_HE Obtener(int IdP, int IdH)
        {
            return DataAccess.Personaje_HEDA.Obtener(IdP, IdH);
        }

        public static int Eliminar(int IdP, int IdH)
        {
            int result = -1;

            result = DataAccess.Personaje_HEDA.Eliminar(IdP, IdH);

            return result;
        }
    }
}
