﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_parte1
{
    public class Clase
    {
        Listados Listados = new Listados();
        public List<Personaje> PersonajeAtributoColeccion { get; set; }
        public List<Habilidad_Especial> HE_AtributoColeccion { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Clase(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public Clase()
        {
           
            //    PersonajeAtributoColeccion = Listados.Personaje_List;
            
        }
    }
}
