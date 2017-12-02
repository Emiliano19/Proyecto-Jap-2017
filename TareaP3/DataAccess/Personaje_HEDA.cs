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
    public class Personaje_HEDA
    {
        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        public static int Agregar(Personaje P, Habilidad_Especial H)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Personaje_HE(IdP, IdH) VALUES (@IdP, @IdH)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@IdP", P.Id);
                com.Parameters.AddWithValue("@IdH", H.Id);

                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }
        
        public static List<Personaje_HE> Listar()
        {
            List<Personaje_HE> result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdP, IdH FROM Personaje_HE";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Personaje_HE>();
                    }

                    Personaje_HE CH = new Personaje_HE();

                    CH.IdP = (int)Reader["IdP"];
                    CH.IdH = (int)Reader["IdH"];

                    result.Add(CH);
                }

            }

            return result;
        }

        public static Personaje_HE Obtener(int IdP, int IdH)
        {
            Personaje_HE result = null;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT IdP, IdH FROM Personaje_HE WHERE IdP = @IdP and IdH = @IdH";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdP", IdP);
                com.Parameters.AddWithValue("@IdH", IdH);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Personaje_HE();

                    result.IdP = (int)Reader["IdP"];
                    result.IdH = (int)Reader["IdH"];

                }
            }

            return result;
        }

        public static int Eliminar(int IdP, int IdH)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Delete Personaje_HE WHERE [IdP] = @IdP and [IdH] = @IdH";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@IdP", IdP);
                com.Parameters.AddWithValue("@IdH", IdH);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}
