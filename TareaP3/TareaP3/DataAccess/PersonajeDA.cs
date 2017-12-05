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
    public class PersonajeDA
    {
        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        public static int Agregar(Personaje Personaje)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Personaje(Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduría, Carisma, IdR, IdC) VALUES (@Nombre, @Nivel, @Fuerza, @Destreza, @Constitución, @Inteligencia, @Sabiduría, @Carisma, @IdR, @IdC)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nivel", Personaje.Nivel);
                com.Parameters.AddWithValue("@Fuerza", Personaje.Fuerza);
                com.Parameters.AddWithValue("@Destreza", Personaje.Destreza);
                com.Parameters.AddWithValue("@Constitución", Personaje.Constitucion);
                com.Parameters.AddWithValue("@Inteligencia", Personaje.Inteligencia);
                com.Parameters.AddWithValue("@Sabiduría", Personaje.Sabiduria);
                com.Parameters.AddWithValue("@Carisma", Personaje.Carisma);
                com.Parameters.AddWithValue("@IdR", Personaje.RazaAtributo.Id);
                com.Parameters.AddWithValue("@IdC", Personaje.ClaseAtributo.Id);


                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Personaje> Listar()
        {
            List<Personaje> result = null;
            
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
 
                string query = "SELECT IdPer, Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduría, Carisma, IdR, IdC FROM Personaje";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();
               
                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Personaje>();
                    }

                    Domain.Personaje P = new Personaje();
                   
                    P.Id = (int)Reader["IdPer"];
                    P.Nombre = Reader["Nombre"].ToString();
                    P.Nivel = (int)Reader["Nivel"];
                    P.Fuerza = (int)Reader["Fuerza"];
                    P.Destreza = (int)Reader["Destreza"];
                    P.Constitucion = (int)Reader["Constitución"];
                    P.Inteligencia = (int)Reader["Inteligencia"];
                    P.Sabiduria = (int)Reader["Sabiduría"];
                    P.Carisma = (int)Reader["Carisma"];
                    P.RazaAtributo = RazaDA.Obtener((int)Reader["IdR"]);
                    P.ClaseAtributo = ClaseDA.Obtener((int)Reader["IdC"]);
          

                    result.Add(P);
                }

            }

            return result;
        }

        public static Personaje Obtener(int id)
        {
            Personaje result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdPer, Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduría, Carisma, IdR, IdC FROM Personaje WHERE IdPer = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Personaje();

                    result.Id = (int)Reader["IdPer"];
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Nivel = (int)Reader["Nivel"];
                    result.Fuerza = (int)Reader["Fuerza"];
                    result.Destreza= (int)Reader["Destreza"];
                    result.Constitucion = (int)Reader["Constitución"];
                    result.Inteligencia = (int)Reader["Inteligencia"];
                    result.Sabiduria = (int)Reader["Sabiduría"];
                    result.Carisma = (int)Reader["Carisma"];
                    result.RazaAtributo = RazaDA.Obtener((int)Reader["IdR"]);
                    result.ClaseAtributo = ClaseDA.Obtener((int)Reader["IdC"]);

                }
            }

            return result;
        }

        public static int Modificar(Personaje P)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Personaje SET [Nombre] = @Nombre, [Nivel] = @Nivel, [Fuerza] = @Fuerza, [Destreza] = @Destreza, [Constitución] = @Constitución, [Inteligencia] = @Inteligencia, [Sabiduría] = @Sabiduría, [Carisma] = @Carisma, [IdR] = @IdR, [IdC] = @IdC WHERE [IdPer] = @IdPer";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdPer", P.Id);
                com.Parameters.AddWithValue("@Nombre", P.Nombre);
                com.Parameters.AddWithValue("@Nivel", P.Nivel);
                com.Parameters.AddWithValue("@Fuerza", P.Fuerza);
                com.Parameters.AddWithValue("@Destreza", P.Destreza);
                com.Parameters.AddWithValue("@Constitución", P.Constitucion);
                com.Parameters.AddWithValue("@Inteligencia", P.Inteligencia);
                com.Parameters.AddWithValue("@Sabiduría", P.Sabiduria);
                com.Parameters.AddWithValue("@Carisma", P.Carisma);
                com.Parameters.AddWithValue("@IdR", P.RazaAtributo.Id);
                com.Parameters.AddWithValue("@IdC", P.ClaseAtributo.Id);


                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(int IdP)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Personaje WHERE [IdPer] = @IdP";
       
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdP", IdP);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}