﻿using System;
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
        public static Habilidad_Especial Obtener(int id)
        {
            return DataAccess.HabilidadEspecialDA.Obtener(id);
        }
    }
}
