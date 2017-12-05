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
    public class CaracteristicaDA
    {
        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        public static int Agregar(Caracteristica Caracteristica)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Caracteristica(Nombre) VALUES (@Nombre)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Caracteristica.Nombre);

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Caracteristica> Listar()
        {
            List<Caracteristica> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdCar, Nombre FROM Caracteristica";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Caracteristica>();
                    }

                    Domain.Caracteristica C = new Caracteristica();

                    C.Id = (int)Reader["IdCar"];
                    C.Nombre = Reader["Nombre"].ToString();
                    result.Add(C);
                }

            }

            return result;
        }

        public static Caracteristica Obtener(int id)
        {
            Caracteristica result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdCar, Nombre FROM Caracteristica WHERE IdCar = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Caracteristica();

                    result.Id = (int)Reader["IdCar"];
                    result.Nombre = Reader["Nombre"].ToString();
                    
                }
            }

            return result;
        }

        public static int Modificar(Caracteristica C)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Caracteristica SET [Nombre] = @Nombre WHERE [IdCar] = @IdCar";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdCar", C.Id);
                com.Parameters.AddWithValue("@Nombre", C.Nombre);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(int IdCar)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Caracteristica WHERE [IdCar] = @IdCar";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdCar", IdCar);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

    }
}
