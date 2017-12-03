using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class PersonajeBL
    {
        public static int Agregar(Personaje Personaje)
        {
            int result = -1;

            result = DataAccess.PersonajeDA.Agregar(Personaje);

            return result;
        }

        public static List<Personaje> Listar()
        {
            List<Personaje> result = null;

            result = DataAccess.PersonajeDA.Listar();

            return result;
        }

        public static Personaje Obtener(int id)
        {
            return DataAccess.PersonajeDA.Obtener(id);
        }

        public static int Modificar(Personaje Personaje, int IdR, int IdC)
        {
            int result = -1;

            result = DataAccess.PersonajeDA.Modificar(Personaje, IdR, IdC);

            return result;
        }

        public static int RetornaRazaId(Personaje P)
        {
            int result = DataAccess.PersonajeDA.RetornaRazaId(P);

            return result;
        }

        public static int RetornaClaseId(Personaje P)
        {
            int result = DataAccess.PersonajeDA.RetornaRazaId(P);

            return result;
        }

        public static int Eliminar(int IdP)
        {
            int result = -1;

            if (CaracteristicaBL.Listar() != null)
            {
                foreach (Caracteristica C in CaracteristicaBL.Listar())
                {
                    Personaje_Caracteristica PC = Personaje_CaracteristicaBL.Obtener(IdP, C.Id);
                    if (PC != null)
                    {
                        Personaje_CaracteristicaBL.Eliminar(IdP, C.Id);
                    }

                }

            }
            if (HabilidadEspecialBL.Listar() != null)
            {
                foreach (Habilidad_Especial H in HabilidadEspecialBL.Listar())
                {
                    Personaje_HE PH = Personaje_HEBL.Obtener(IdP, H.Id);
                    if (PH != null)
                    {
                        Personaje_HEBL.Eliminar(IdP, H.Id);
                    }

                }

            }
            result = DataAccess.PersonajeDA.Eliminar(IdP);

            return result;
        }

    }
}
