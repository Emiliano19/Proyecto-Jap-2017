﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class Personaje_CaracteristicaDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static int Agregar(Personaje P, Caracteristica C, int Valor)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Personaje_Caracteristica(IdPersonaje, IdCaracteristica, Valor) VALUES (@IdPersonaje, @IdCaracteristica, @Valor)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@IdPersonaje", P.Id);
                com.Parameters.AddWithValue("@IdCaracteristica", C.Id);
                com.Parameters.AddWithValue("@Valor", Valor);

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static Personaje_Caracteristica Obtener(int IdP, int IdC)
        {
            Personaje_Caracteristica result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdPersonaje, IdCaracteristica, Valor From Personaje_Caracteristica WHERE IdCaracteristica = @IdCaracteristica and IdPersonaje = @IdPersonaje";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdPersonaje", IdP);
                com.Parameters.AddWithValue("@IdCaracteristica", IdC);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Personaje_Caracteristica();

                    result.valor = (int)Reader["Valor"];
                 
                }

            }

            return result;
        }

        public static List<Personaje_Caracteristica> Listar()
        {
            List<Personaje_Caracteristica> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdP, IdC, Valor FROM Personaje_Caracteristica";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("IdP", );

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Personaje_Caracteristica>();
                    }

                    Personaje_Caracteristica C = new Personaje_Caracteristica();

                    C.CaracteristicaV.Id = (int)Reader["IdC"];
                    C.valor = (int)Reader["Valor"];
                    result.Add(C);
                }

            }

            return result;
        }

        public static int Modificar(int IdP, int IdC, int Valor)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Personaje_Caracteristica SET [IdPersonaje] = @IdPersonaje, [IdCaracteristica] = @IdCaracteristica, [Valor] = @Valor WHERE [IdCaracteristica] = @IdCaracteristica";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdPersonaje", IdP);
                com.Parameters.AddWithValue("@IdCaracteristica", IdC);
                com.Parameters.AddWithValue("@Valor", Valor);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(int IdP, int IdC)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Personaje_Caracteristica WHERE [IdPersonaje] = @id and [IdCaracteristica] = @id1";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", IdP);
                com.Parameters.AddWithValue("@id1", IdC);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}