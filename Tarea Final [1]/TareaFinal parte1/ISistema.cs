using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    interface ISistema
    {
        void CrearHabilidadHespecial();
        void ModificarHabilidadEspecial();
        void ListarHabilidadesHespeciales();
        void ListarHabilidadesHespecialesPorClase();
        void EliminarHabilidadEspecialPorHabilidadEspecial();

        Clase CrearClase();
        void ModificarClase();
        void ListarClases();
        void EliminarClase();

        Raza CrearRaza();
        void ModificarRaza();
        void ListarRazas();
        void EliminarRaza();

        void CrearCaracteristica();
        void ModificarCaracteristica();
        void ListarCaracteristicas();
        void EliminarCaracteristica();

        void CrearPersonaje();
        void ModificarPersonaje();
        void ListarPersonaje();
        void ListarPersonajesPorRaza();
        void ListarPersonajesPorClase();
        void EliminarPersonaje();

    }
}
