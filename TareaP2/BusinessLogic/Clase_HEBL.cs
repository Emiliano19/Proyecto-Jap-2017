using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class Clase_HEBL
    {
        public static int Agregar(Clase C, Habilidad_Especial H)
        {
            int result = -1;

            result = DataAccess.Clase_HEDA.Agregar(C, H);

            return result;
        }

        public static List<Clase_HE> Listar()
        {
            List<Clase_HE> result = null;

            result = DataAccess.Clase_HEDA.Listar();

            return result;
        }

        public static Clase_HE Obtener(int IdC, int IdH)
        {
            return DataAccess.Clase_HEDA.Obtener(IdC, IdH);
        }
    }
}
