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

        public static int Modificar(Personaje Personaje)
        {
            int result = -1;

            result = DataAccess.PersonajeDA.Modificar(Personaje);

            return result;
        }

        public static int Eliminar(int IdP)
        {
            int result = -1;

            result = DataAccess.PersonajeDA.Eliminar(IdP);

            return result;
        }

    }
}
