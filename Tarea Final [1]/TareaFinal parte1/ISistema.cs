using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    interface ISistema
    {
        void SimulaciondelJuego();
        void SubirdeNivel();

        Habilidad_Especial CrearHabilidadHespecial();
        void ModificarHabilidadEspecial();
        void ListarHabilidadEspecial();
        void ListarHabilidadHespecialPorClase();
        void EliminarHabilidadEspecial();

        Clase CrearClase();
        void ModificarClase();
        void ListarClases();
        void EliminarClase();

        Raza CrearRaza();
        void ModificarRaza();
        void ListarRazas();
        void EliminarRaza();

        Caracteristica_Variable CrearCaracteristica();
        void ModificarCaracteristica();
        void ListarCaracteristicas();
        void EliminarCaracteristica();

        Personaje CrearPersonaje();
        void ModificarPersonaje();
        void ListarPersonaje();
        void ListarPersonajesPorRaza();
        void ListarPersonajesPorClase();
        void EliminarPersonaje();

    }
}
