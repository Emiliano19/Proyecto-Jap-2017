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
using System.Data;

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
            listview.ItemsSource = BusinessLogic.PersonajeBL.Listar();
            ComboRaza.ItemsSource = BusinessLogic.RazaBL.Listar();
            ComboRaza.SelectedValuePath = "IdRaza";
            ComboRaza.DisplayMemberPath = "Nombre";

            ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
            ComboClase.SelectedValuePath = "IdClase";
            ComboClase.DisplayMemberPath = "Nombre";
        }

        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listview.ItemsSource = BusinessLogic.PersonajeBL.Listar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int selectedIndex = ComboRaza.SelectedIndex;
            Domain.Raza selectedItem = (Domain.Raza)ComboRaza.SelectedItem;

            Prueba.Text = selectedItem.Nombre;
        }
    }
}
