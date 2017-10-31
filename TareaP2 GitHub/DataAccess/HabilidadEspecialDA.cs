using System;
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

        public static int Agregar(Habilidad_Especial HES)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Habilidad_Especial(Nombre, Descripción) VALUES (@Nombre, @Descripción)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", HES.Nombre);
                com.Parameters.AddWithValue("@Descripción", HES.Descripcion);

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Habilidad_Especial> Listar()
        {
            List<Habilidad_Especial> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdHE, Nombre, Descripción FROM Habilidad_Especial";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Habilidad_Especial>();
                    }

                    Domain.Habilidad_Especial H = new Habilidad_Especial();

                    H.Id = (int)Reader["IdHE"];
                    H.Nombre = Reader["Nombre"].ToString();
                    H.Descripcion = Reader["Descripción"].ToString();

                    result.Add(H);
                }

            }

            return result;
        }

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

                    result.Id = (int)Reader["IdHE"];
                    result.Nombre = Reader["Nombre"].ToString();
                    result.Descripcion = Reader["Descripción"].ToString();

                }
            }

            return result;
        }

        public static int Modificar(Habilidad_Especial HES)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Habilidad_Especial SET [Nombre] = @Nombre, [Descripción] = @Descripción WHERE [IdHE] = @IdHE";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdHE", HES.Id);
                com.Parameters.AddWithValue("@Nombre", HES.Nombre);
                com.Parameters.AddWithValue("@Descripción", HES.Descripcion);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(int IdH)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Habilidad_Especial WHERE [IdHE] = @IdH";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdH", IdH);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}
