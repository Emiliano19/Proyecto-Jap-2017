using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class ClaseBL
    {
        public static int Agregar(Clase Clase)
        {
            int result = -1;

            result = DataAccess.ClaseDA.Agregar(Clase);

            return result;
        }

        public static List<Clase> Listar()
        {
            List<Clase> result = null;

            result = DataAccess.ClaseDA.Listar();

            return result;
        }

        public static Clase Obtener(int id)
        {
            return DataAccess.ClaseDA.Obtener(id);
        }

        public static int Modificar(Clase Clase)
        {
            int result = -1;

            result = DataAccess.ClaseDA.Modificar(Clase);

            return result;
        }

        public static int Eliminar(int IdC)
        {
            int result = -1;
            if(BusinessLogic.HabilidadEspecialBL.Listar() != null)
            {
                foreach (Domain.Habilidad_Especial HC in BusinessLogic.HabilidadEspecialBL.Listar())
                {
                    Domain.Clase_HE H = BusinessLogic.Clase_HEBL.Obtener(IdC, HC.Id);
                    if (H != null)
                    {
                        BusinessLogic.Clase_HEBL.Eliminar(IdC, HC.Id);
                    }
                }
            }
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                foreach(Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    if(P.ClaseAtributo.Id == IdC)
                    {
                        int Idc = 10;
                        int IDr = P.RazaAtributo.Id;
                        BusinessLogic.PersonajeBL.Modificar(P, IDr, Idc);
                    }
                }
            }

            result = DataAccess.ClaseDA.Eliminar(IdC);

            return result;
        }

    }

}
