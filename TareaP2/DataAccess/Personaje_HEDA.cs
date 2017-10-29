using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class Personaje_HEDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-3V542RP\\SQLEXPRESS";

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
    }
}
