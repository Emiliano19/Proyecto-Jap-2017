using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class Personaje_CaracteristicaDA
    {
        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        public static int Agregar(int IdP, int IdC, int Valor)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Personaje_Caracteristica(IdPersonaje, IdCaracteristica, Valor) VALUES (@IdPersonaje, @IdCaracteristica, @Valor)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@IdPersonaje", IdP);
                com.Parameters.AddWithValue("@IdCaracteristica", IdC);
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
                string query = "SELECT Valor From Personaje_Caracteristica WHERE IdPersonaje = @IdPersonaje and IdCaracteristica = @IdCaracteristica";
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
                string query = "SELECT IdPersonaje, IdCaracteristica, Valor FROM Personaje_Caracteristica";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Personaje_Caracteristica>();
                    }

                    Personaje_Caracteristica PC = new Personaje_Caracteristica();

                    PC.CaracteristicaV.Id = (int)Reader["IdCaracteristica"];
                    PC.valor = (int)Reader["Valor"];
                    result.Add(PC);
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
                string query = "UPDATE Personaje_Caracteristica SET [Valor] = @Valor WHERE [IdPersonaje] = @IdPersonaje and [IdCaracteristica] = @IdCaracteristica";

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
                string query = "Delete Personaje_Caracteristica WHERE [IdPersonaje] = @IdP and [IdCaracteristica] = @IdC";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdP", IdP);
                com.Parameters.AddWithValue("@IdC", IdC);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}
