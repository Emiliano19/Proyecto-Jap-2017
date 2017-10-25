﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class HabilidadEspecialDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static Habilidad_Especial Obtener(int id)
        {
            Habilidad_Especial result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdHE, Nombre, Descripción FROM Habilidad_Especial WHERE IdHE = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Habilidad_Especial();

                    result.Id = (int)Reader["IdPer"];
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Descripcion = Reader["Descripción"].ToString();

                }
            }

            return result;
        }
    }
}
