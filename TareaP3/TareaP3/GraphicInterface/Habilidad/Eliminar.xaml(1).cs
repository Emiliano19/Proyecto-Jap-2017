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
using System.Configuration;

namespace GraphicInterface.Habilidad
{
    /// <summary>
    /// Lógica de interacción para Eliminar.xaml
    /// </summary>
    public partial class Eliminar : Page
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<Domain.Habilidad_Especial> result = null;

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
                        result = new List<Domain.Habilidad_Especial>();
                    }

                    Domain.Habilidad_Especial H = new Domain.Habilidad_Especial();

                    H.Id = (int)Reader["IdHE"];
                    H.Nombre = Reader["Nombre"].ToString();
                    H.Descripcion = Reader["Descripción"].ToString();

                    result.Add(H);
                }
                listview.ItemsSource = result;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach(ListViewItem List in listview.ItemsSource)
            {
                
            }
            Domain.Habilidad_Especial H = //Igual a la habilidad seleccionada por el checkbox
        }
    }
}
