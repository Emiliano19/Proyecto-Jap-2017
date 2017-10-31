using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Interfaces
{
    interface Habilidad_EspecialInterface
    {
        Habilidad_Especial CrearHabilidadHespecial();
        void ModificarHabilidadEspecial();
        void ListarHabilidadesEspeciales();
        void ListarHabilidadHespecialPorClase();
        void EliminarHabilidadEspecial();
    }
}
