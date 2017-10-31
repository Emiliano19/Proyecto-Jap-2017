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

        public static int Agregar(Raza Raza)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Raza(IdCar, Nombre, Descripción, ValorPlus) VALUES (@IdCar, @Nombre, @Descripción, @ValorPlus)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@IdCar", Raza.Caract_VarRazaAtributo.Id);
                com.Parameters.AddWithValue("@Nombre", Raza.Nombre);
                com.Parameters.AddWithValue("@Descripción", Raza.Descripcion);
                com.Parameters.AddWithValue("@ValorPlus", Raza.ValorPlus);
                
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
                string query = "SELECT IdRaza, IdCar, Nombre, Descripción, ValorPlus FROM Raza";
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
                    R.Caract_VarRazaAtributo = CaracteristicaDA.Obtener((int)Reader["IdCar"]);
                    R.Nombre = Reader["Nombre"].ToString();
                    R.Descripcion = Reader["Descripción"].ToString();
                    R.ValorPlus = (int)Reader["ValorPlus"];

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
                string query = "SELECT IdRaza, IdCar, Nombre, Descripción, ValorPlus FROM Raza WHERE IdRaza = @id";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Raza();

                    result.Id = (int)Reader["IdRaza"];
                    result.Caract_VarRazaAtributo = CaracteristicaDA.Obtener((int)Reader["IdCar"]);
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Descripcion = Reader["Descripción"].ToString();
                    result.ValorPlus = (int)Reader["ValorPlus"];
                }
            }

            return result;
        }

        public static int Modificar(Raza Raza, int IdC)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Raza SET [IdCar] = @IdCar, [Nombre] = @Nombre, [Descripción] = @Descripción, [ValorPlus] = @ValorPlus WHERE [IdRaza] = @IdRaza";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdRaza", Raza.Id);
                com.Parameters.AddWithValue("@IdCar", IdC);
                com.Parameters.AddWithValue("@Nombre", Raza.Nombre);
                com.Parameters.AddWithValue("@Descripción", Raza.Descripcion);
                com.Parameters.AddWithValue("@ValorPlus", Raza.ValorPlus);

                result = com.ExecuteNonQuery();

                connection.Close();
                
            }

            return result;
            
        }

        public static int Eliminar(Raza Raza)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Raza WHERE [IdRaza] = @id";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@id", Raza.Id);

                result = com.ExecuteNonQuery();
 
                connection.Close();

            }

            return result;

        }

    }

}
