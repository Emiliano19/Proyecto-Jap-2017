using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class Clase_HEDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static int Agregar(Clase C, Habilidad_Especial H)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Clase_HE(IdC, IdH) VALUES (@IdC, @IdH)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@IdC", C.Id);
                com.Parameters.AddWithValue("@IdH", H.Id);

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Clase_HE> Listar()
        {
            List<Clase_HE> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdC, IdH FROM Clase_HE";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Clase_HE>();
                    }

                    Clase_HE CH = new Clase_HE();

                    CH.IdC = (int)Reader["IdC"];
                    CH.IdH = (int)Reader["IdH"];

                    result.Add(CH);
                }

            }

            return result;
        }

        public static Clase_HE Obtener(int IdC, int IdH)
        {
            Clase_HE result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdC, IdH FROM Clase_HE WHERE IdC = @idc and IdH = @idh";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@idc", IdC);
                com.Parameters.AddWithValue("@idh", IdH);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Clase_HE();

                    result.IdC = (int)Reader["IdC"];
                    result.IdH = (int)Reader["IdH"];

                }
            }

            return result;
        }

        public static int Eliminar(int IdC, int IdH)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Clase_HE WHERE [IdC] = @IdC and [IdH] = @IdH";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdC", IdC);
                com.Parameters.AddWithValue("@IdH", IdH);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }

}
