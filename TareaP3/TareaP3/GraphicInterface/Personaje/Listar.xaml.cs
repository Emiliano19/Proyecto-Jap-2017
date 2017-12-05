using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using BusinessLogic;
using System.Configuration;

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
        }

        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        private void IvDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            List<Domain.Personaje> result = null;
           
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {

                string query = "SELECT IdPer, Nombre, Nivel, Fuerza, Destreza, Constitución, Inteligencia, Sabiduría, Carisma FROM Personaje";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Domain.Personaje>();
                    }

                    Domain.Personaje P = new Domain.Personaje();

                    P.Id = (int)Reader["IdPer"];
                    P.Nombre = Reader["Nombre"].ToString();
                    P.Nivel = (int)Reader["Nivel"];
                    P.Fuerza = (int)Reader["Fuerza"];
                    P.Destreza = (int)Reader["Destreza"];
                    P.Constitucion = (int)Reader["Constitución"];
                    P.Inteligencia = (int)Reader["Inteligencia"];
                    P.Sabiduria = (int)Reader["Sabiduría"];
                    P.Carisma = (int)Reader["Carisma"];

                    result.Add(P);
                    
                }
                listview.ItemsSource = result;
            }
            

        }
    }
}
