using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public class CaracteristicaBL
    {
        public static int Agregar(Caracteristica Caracteristica)
        {
            int result = -1;

            result = CaracteristicaDA.Agregar(Caracteristica);

            return result;
        }

        public static List<Caracteristica> Listar()
        {
            List<Caracteristica> result = null;

            result = CaracteristicaDA.Listar();

            return result;
        }

        public static Caracteristica Obtener(int id)
        {
            return CaracteristicaDA.Obtener(id);
        }

        public static int Modificar(Caracteristica Caracteristica)
        {
            int result = -1;

            result = CaracteristicaDA.Modificar(Caracteristica);

            return result;
        }

        public static int Eliminar(int IdC)
        {
            int result = -1;

            if (PersonajeBL.Listar() != null)
            {
                foreach (Personaje P in PersonajeBL.Listar())
                {
                    Personaje_Caracteristica PC = Personaje_CaracteristicaBL.Obtener(P.Id, IdC);
                    if (PC != null)
                    {
                        Personaje_CaracteristicaBL.Eliminar(P.Id, IdC);
                    }

                }

            }
            Caracteristica CA = Obtener(IdC);
            if (RazaBL.Listar() != null)
            {
                foreach (Raza R in RazaBL.Listar())
                {
                    if (R.Caract_VarRazaAtributo.Id == CA.Id)
                    {
                        int Idc = 6;
                        RazaBL.Modificar(R, Idc);

                    }

                }

            }
            if (BusinessLogic.PersonajeBL.Listar() != null)
            {
                foreach (Domain.Personaje p in BusinessLogic.PersonajeBL.Listar())
                {
                    Domain.Personaje_Caracteristica PH = BusinessLogic.Personaje_CaracteristicaBL.Obtener(p.Id, CA.Id);
                    if (PH != null)
                    {
                        BusinessLogic.Personaje_CaracteristicaBL.Eliminar(p.Id, CA.Id);
                    }

                }
            }

            result = CaracteristicaDA.Eliminar(IdC);

            return result;
        }
    }
}
