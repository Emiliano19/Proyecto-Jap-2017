using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class HabilidadEspecialBL
    {
        public static int Agregar(Habilidad_Especial HES)
        {
            int result = -1;

            if(HES.Nombre == "" || HES.Descripcion == "")
            {
                result = -1;
            }
            else
            {
                result = DataAccess.HabilidadEspecialDA.Agregar(HES);
            }

            return result;
        }

        public static List<Habilidad_Especial> Listar()
        {
            List<Habilidad_Especial> result = null;

            result = DataAccess.HabilidadEspecialDA.Listar();

            return result;
        }

        public static Habilidad_Especial Obtener(int id)
        {
            return DataAccess.HabilidadEspecialDA.Obtener(id);
        }

        public static int Modificar(Habilidad_Especial HES)
        {
            int result = -1;

            result = DataAccess.HabilidadEspecialDA.Modificar(HES);

            return result;
        }

        public static int Eliminar(int IdH)
        {
            int result = -1;
            foreach(Domain.Clase c in BusinessLogic.ClaseBL.Listar())
            {
                Clase_HEBL.Eliminar(c.Id, IdH);
            }
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                foreach (Domain.Personaje p in BusinessLogic.PersonajeBL.Listar())
                {
                    Domain.Personaje_HE PH = BusinessLogic.Personaje_HEBL.Obtener(p.Id, IdH);
                    if (PH != null)
                    {
                        BusinessLogic.Personaje_HEBL.Eliminar(p.Id, IdH);
                    }

                }
            }
          
            result = DataAccess.HabilidadEspecialDA.Eliminar(IdH);

            return result;
        }
    }
}
