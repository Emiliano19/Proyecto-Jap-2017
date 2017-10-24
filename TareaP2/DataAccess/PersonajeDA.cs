using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace DataAccess
{
    public class PersonajeDA
    {
        static string _ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TareaParte2;Data Source=DESKTOP-JU5V3V1\\SQLEXPRESS01";

        public static int Agregar(Personaje Personaje)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                string query = "INSERT INTO Personaje(Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduria, Carisma, IdRaza, IdClase) VALUES (@Nombre, @Nivel, @Fuerza, @Destreza, @Constitución, @Inteligencia, @Sabiduria, @Carisma, @IdRaza, @IdClase)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nivel", Personaje.Nivel);
                com.Parameters.AddWithValue("@Fuerza", Personaje.Fuerza);
                com.Parameters.AddWithValue("@Destreza", Personaje.Destreza);
                com.Parameters.AddWithValue("@Constitución", Personaje.Constitucion);
                com.Parameters.AddWithValue("@Inteligencia", Personaje.Inteligencia);
                com.Parameters.AddWithValue("@Sabiduria", Personaje.Sabiduria);
                com.Parameters.AddWithValue("@Carisma", Personaje.Carisma);
                com.Parameters.AddWithValue("@IdRaza", Personaje.RazaAtributo.Id);
                com.Parameters.AddWithValue("@IdClase", Personaje.ClaseAtributo.Id);


                connection.Open();

                result = com.ExecuteNonQuery();

            }

            return result;
        }

        public static List<Personaje> Listar()
        {
            List<Personaje> result = null;
            int id = 0;
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
 
                string query = "SELECT IdPer, Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduria, Carisma, IdRaza, IdClase FROM Personaje";
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
                    id = (int)Reader["Idraza"];
                    P.Id = (int)Reader["IdPer"];
                    P.Nombre = Reader["Nombre"].ToString();
                    P.Nivel = (int)Reader["Nivel"];
                    P.Fuerza = (int)Reader["Fuerza"];
                    P.Destreza = (int)Reader["Destreza"];
                    P.Constitucion = (int)Reader["Constitución"];
                    P.Inteligencia = (int)Reader["Inteligencia"];
                    P.Sabiduria = (int)Reader["Sabiduria"];
                    P.Carisma = (int)Reader["Carisma"];
                    P.RazaAtributo = RazaDA.Obtener(id);
                    //  P.ClaseAtributo = ClaseDA.Obtener(IdClase);


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
                string query = "SELECT IdPer, Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduria, Carisma, IdRaza, IdClase FROM Personaje FROM Personaje WHERE IdPersonaje = @id";
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
                    result.Nivel = (int)Reader["Fuerza"];
                    result.Nivel = (int)Reader["Destreza"];
                    result.Nivel = (int)Reader["Constitución"];
                    result.Nivel = (int)Reader["Inteligencia"];
                    result.Nivel = (int)Reader["Sabiduria"];
                    result.Nivel = (int)Reader["Carisma"];
                    result.Nivel = (int)Reader["IdRaza"];
                    result.Nivel = (int)Reader["IdClase"];

                }
            }

            return result;
        }

        public static int Modificar(Personaje Personaje)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Raza SET [Nombre] = @Nombre, [Nivel] = @Nivel, [Fuerza] = @Fuerza, [Destreza] = @Destreza, [Constitución] = @Constitución, [Inteligencia] = @Inteligencia, [Sabiduria] = @Sabiduria, [Carisma] = @Carisma, [IdRaza] = @IdRaza, [IdClase] = @IdClase";

                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);
                com.Parameters.AddWithValue("@Nombre", Personaje.Nombre);

               /* result.Id = (int)Reader["IdPer"];
                result.Nombre = Reader["Nombre"].ToString();
                result.Nivel = (int)Reader["Nivel"];
                result.Nivel = (int)Reader["Fuerza"];
                result.Nivel = (int)Reader["Destreza"];
                result.Nivel = (int)Reader["Constitución"];
                result.Nivel = (int)Reader["Inteligencia"];
                result.Nivel = (int)Reader["Sabiduria"];
                result.Nivel = (int)Reader["Carisma"];
                result.Nivel = (int)Reader["IdRaza"];
                result.Nivel = (int)Reader["IdClase"];*/

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }

        public static int Eliminar(Personaje Personaje)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                string query = "Clear Personaje WHERE [IdPer] = @id";

                SqlCommand com = new SqlCommand(query, connection);

                result = com.ExecuteNonQuery();

                connection.Close();

            }

            return result;

        }
    }
}
