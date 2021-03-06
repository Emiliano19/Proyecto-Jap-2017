﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class ClaseDA
    {
        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        public static int Agregar(Clase Clase)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Clase(Nombre, Descripción) VALUES (@Nombre, @Descripción)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Clase.Nombre);
                com.Parameters.AddWithValue("@Descripción", Clase.Descripcion);
                
                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Clase> Listar()
        {
            List<Clase> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdClase, Nombre, Descripción FROM Clase";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Clase>();
                    }

                    Domain.Clase C = new Clase();

                    C.Id = (int)Reader["IdClase"];
                    C.Nombre = Reader["Nombre"].ToString();
                    C.Descripcion = Reader["Descripción"].ToString();

                    result.Add(C);
                }

            }

            return result;
        }

        public static Clase Obtener(int id)
        {
            Clase result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdClase, Nombre, Descripción FROM Clase WHERE IdClase = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Clase();

                    result.Id = (int)Reader["IdClase"];
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Descripcion = Reader["Descripción"].ToString();
                   
                }
            }

            return result;
        }

        public static int Modificar(Clase Clase)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Clase SET [Nombre] = @Nombre, [Descripción] = @Descripción WHERE [IdClase] = @IdClase";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdClase", Clase.Id);
                com.Parameters.AddWithValue("@Nombre", Clase.Nombre);
                com.Parameters.AddWithValue("@Descripción", Clase.Descripcion);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(int IdC)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Clase WHERE [IdClase] = @IdC";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdC", IdC);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}
