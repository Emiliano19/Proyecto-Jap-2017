using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class CaracteristicaDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static int Agregar(Caracteristica Caracteristica)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Caracteristica(Nombre, IdPeCa) VALUES (@Nombre, @IdPeCa)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Caracteristica.Nombre);
                //Falta ingresar el valor que es el valor de Personaje caracteristica

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
                    //Falta listar el valor que es el de Personaje caracteristica
                    // R.ValorPluss = (int)Reader["ValorPluss"];

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
                string query = "SELECT IdCar, Nombre, Valor FROM Caracteristica WHERE IdCar = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Caracteristica();

                    result.Id = (int)Reader["IdRaza"];
                    result.Nombre = Reader["Nombre"].ToString();
                    //Falta obtener el valor
                    //result.ValorPluss = (int)Reader["ValorPluss"];
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
                string query = "UPDATE Caracteristica SET [Nombre] = @Nombre, [Descripcion] = @Descripcion WHERE [IdRaza] = @IdRaza";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@Nombre", C.Nombre);
                com.Parameters.AddWithValue("@IdRaza", C.Id);
                //Falta modificar el valor

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(Caracteristica Caracteristica)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Caracteristica WHERE [IdCar] = @id";

                SqlCommand com = new SqlCommand(query, connection);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

    }
}
