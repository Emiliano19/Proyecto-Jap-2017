using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ControladordeCarga
    {
        public Personaje PersonajeV { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Habilidad_Especial H_E { get; set; }
        public Caracteristica P_C { get; set; }


        public List<Personaje> Personaje_List = new List<Personaje>();
        public List<Raza> Raza_List = new List<Raza>();
        public List<Clase> Clase_List = new List<Clase>();
        public List<Caracteristica> Caracteristica_Variabli_List = new List<Caracteristica>();
        public List<Habilidad_Especial> Habilidad_Especial_List = new List<Habilidad_Especial>();



        public ControladordeCarga()
        {
           
            /* Raza_List.Add(new Raza() { Id = 3, Nombre = "Throl", Descripcion = "Poseen gran Fuerza pero poca Inteligencia", ValorPluss = 2 });
             Raza_List.Add(new Raza() { Id = 4, Nombre = "Elfo", Descripcion = "Baja constitucion y fuerza pero muy inteligentes", ValorPluss = 4 });
             Raza_List.Add(new Raza() { Id = 5, Nombre = "Gigante", Descripcion = "Muy elevada constitucion y una descomunal fuerza fisica", ValorPluss = 3 });
             Raza_List.Add(new Raza() { Id = 6, Nombre = "Hobit", Descripcion = "Iteligentes habiles y muy sabios", ValorPluss = 5 });
             Raza_List.Add(new Raza() { Id = 7, Nombre = "Mago", Descripcion = "Le sobra sabiduria y por sobre todo un gran poder magico", ValorPluss = 2 });*/

            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 1, Nombre = "FuerzaBrutal", Descripcion = "Le otorga al personaje una fuerza incomparable" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 2, Nombre = "Forjar", Descripcion = "Le da al personaje la habilidad de forjar armas y armaduras para la batalla" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 3, Nombre = "Improvisacion", Descripcion = "Habilidad que les permite improvisar cosas rapidamente en momentos criticos" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 4, Nombre = "BuenObservador", Descripcion = "Le permite prestar atencion a los detalles en cualquier ambito" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 5, Nombre = "RapidaEmpatia", Descripcion = "Logra que el personaje se ponga en el lugar de otro y persevir lo que siente" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 6, Nombre = "Afortunado", Descripcion = "Logra todo lo que se propone" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 7, Nombre = "AudasEspadachin", Descripcion = "le permite sobre todo a los guerreros aumentar potencial en la batalla" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 8, Nombre = "Sigiloso", Descripcion = "Logra que el Personaje se mueva precavidamente y sin levantar sospechas" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 9, Nombre = "AudasMentiroso", Descripcion = "Le sirve para escapar de situaciones usando el pequeño poder de la mentira" });
            Habilidad_Especial_List.Add(new Habilidad_Especial() { Id = 10, Nombre = "HabilidadX", Descripcion = "Poder descomunal que le da infinitas habilidades al Personaje si la consigue" });

            Clase_List.Add(new Clase() { Id = 1, Nombre = "Civiles", Descripcion = "Todos los seres e cualquier Raza que no pertenecen a una Clase especifica" });
            Clase_List.Add(new Clase() { Id = 2, Nombre = "Artilleros", Descripcion = "Se encargan de las armas y l artilleria en general en batalla" });
            Clase_List.Add(new Clase() { Id = 3, Nombre = "Escuderos", Descripcion = "Guerreros de apollo de los Caballeros en el campo de batalla" });
            Clase_List.Add(new Clase() { Id = 4, Nombre = "Caballeros", Descripcion = "Guerreros que poseen un titulo de noblesa por su valentia y fuerza" });
            Clase_List.Add(new Clase() { Id = 5, Nombre = "Guerreos de la Luz", Descripcion = "Es una clase especial de Guerreros que interviene en conflictos entre Reinos" });
            Clase_List.Add(new Clase() { Id = 6, Nombre = "Salvajes", Descripcion = "Humanos que viven escondidos en los terrorificos bosques obscuros" });

            Clase_List.ElementAt(0).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(0));
            Clase_List.ElementAt(0).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(1));
            Clase_List.ElementAt(1).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(2));
            Clase_List.ElementAt(1).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(3));
            Clase_List.ElementAt(2).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(4));
            Clase_List.ElementAt(2).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(5));
            Clase_List.ElementAt(3).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(6));
            Clase_List.ElementAt(3).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(7));
            Clase_List.ElementAt(4).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(8));
            Clase_List.ElementAt(4).HE_AtributoColeccion.Add(Habilidad_Especial_List.ElementAt(9));

            P_C = new Caracteristica() { Id = 1, Nombre = "Navajero" };
            Caracteristica_Variabli_List.Add(P_C);

            P_C = new Caracteristica() { Id = 2, Nombre = "Destructor" };
            Caracteristica_Variabli_List.Add(P_C);

            P_C = new Caracteristica() { Id = 3, Nombre = "Golpeador" };
            Caracteristica_Variabli_List.Add(P_C);


            Personaje PersonajeK = new Personaje();
            PersonajeK.Id = 2;
            PersonajeK.Nombre = "GuerreroBlack";
            PersonajeK.Nivel = 1;
            PersonajeK.Fuerza = 4;
            PersonajeK.Destreza = 2;
            PersonajeK.Constitucion = 4;
            PersonajeK.Inteligencia = 5;
            PersonajeK.Sabiduria = 7;
            PersonajeK.Carisma = 10;
            PersonajeK.RazaAtributo = Raza_List.ElementAt(1);
            PersonajeK.ClaseAtributo = Clase_List.ElementAt(1);
            foreach (Caracteristica pERIcAR in Caracteristica_Variabli_List)
            {
                PersonajeK.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcAR, valor = 1 });
            }
            Personaje_List.Add(PersonajeK);

            Personaje PersonajeL = new Personaje();
            PersonajeL.Id = 3;
            PersonajeL.Nombre = "DraigonelBarBaro";
            PersonajeL.Nivel = 7;
            PersonajeL.Fuerza = 10;
            PersonajeL.Destreza = 2;
            PersonajeL.Constitucion = 3;
            PersonajeL.Inteligencia = 5;
            PersonajeL.Sabiduria = 4;
            PersonajeL.Carisma = 1;
            PersonajeL.RazaAtributo = Raza_List.ElementAt(6);
            PersonajeL.ClaseAtributo = Clase_List.ElementAt(3);
            foreach (Caracteristica pERIcARL in Caracteristica_Variabli_List)
            {
                PersonajeL.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcARL, valor = 1 });
            }
            Personaje_List.Add(PersonajeL);

            Personaje PersonajeH = new Personaje();
            PersonajeH.Id = 4;
            PersonajeH.Nombre = "Hitmis";
            PersonajeH.Nivel = 2;
            PersonajeH.Fuerza = 4;
            PersonajeH.Destreza = 1;
            PersonajeH.Constitucion = 9;
            PersonajeH.Inteligencia = 5;
            PersonajeH.Sabiduria = 8;
            PersonajeH.Carisma = 10;
            PersonajeH.RazaAtributo = Raza_List.ElementAt(4);
            PersonajeH.ClaseAtributo = Clase_List.ElementAt(2);
            foreach (Caracteristica pERIcARH in Caracteristica_Variabli_List)
            {
                PersonajeH.C_VAtributoColeccion.Add(new Personaje_Caracteristica() { CaracteristicaV = pERIcARH, valor = 1 });
            }
            Personaje_List.Add(PersonajeH);

        }

    }

}
