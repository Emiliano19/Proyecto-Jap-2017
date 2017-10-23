using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class RazaDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static int Add(Raza Raza)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Raza(Nombre, Descripcion, ValorPluss) VALUES (@Nombre, @Descripcion)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Raza.Nombre);
                com.Parameters.AddWithValue("@Descripcion", Raza.Descripcion);
              /*  com.Parameters.AddWithValue("@ValorPluss", Raza.ValorPluss);*/

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Raza> Listar()
        {
            List<Raza> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdRaza, Nombre, Descripcion, ValorPluss FROM Raza";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Raza>();
                    }

                    Domain.Raza R = new Raza();

                    R.Id = (int)Reader["IdRaza"];
                    R.Nombre = Reader["Nombre"].ToString();
                    R.Descripcion = Reader["Descripcion"].ToString();
                   // R.ValorPluss = (int)Reader["ValorPluss"];

                    result.Add(R);
                }

            }

            return result;
        }

        public static Raza Obtener(int id)
        {
            Raza result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdRaza, Nombre, Descripcion, ValorPluss FROM Raza WHERE IdRaza = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Raza();

                    result.Id = (int)Reader["IdRaza"];
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Descripcion = Reader["Descripcion"].ToString();
                    //result.ValorPluss = (int)Reader["ValorPluss"];
                }
            }

            return result;
        }

        public static int Modificar(Raza r)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Raza SET [Nombre] = @Nombre, [Descripcion] = @Descripcion WHERE [IdRaza] = @IdRaza";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@Nombre", r.Nombre);
                com.Parameters.AddWithValue("@IdRaza", r.Id);
                com.Parameters.AddWithValue("@Descripcion", r.Descripcion);

                result = com.ExecuteNonQuery();

                connection.Close();
                
            }

            return result;
            
        }

    }

}
