﻿using System;
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

            result = DataAccess.ClaseDA.Eliminar(IdC);

            return result;
        }

    }

}
