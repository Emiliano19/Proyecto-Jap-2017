using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Interfaces
{
    interface PersonajeInterface
    {
        Personaje CrearPersonaje();
        void ModificarPersonaje();
        void ListarPersonajes();
        void ListarPersonajesPorRaza();
        void ListarPersonajesPorClase();
        void EliminarPersonaje();
    }
}
