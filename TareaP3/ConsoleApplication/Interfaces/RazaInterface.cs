using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BusinessLogic;

namespace ConsoleApplication.Interfaces
{
    interface RazaInterface
    {
        Raza CrearRaza();
        void ModificarRaza();
        void ListarRazas();
        void EliminarRaza();
    }
}
