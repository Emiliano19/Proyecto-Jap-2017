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

namespace GraphicInterface
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_5(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Personaje.Crear());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Personaje.Listar());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Habilidad.Crear());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Habilidad.Listar());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Caracteristica.Crear());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Caracteristica.Listar());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Raza.Crear());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Clase.Crear());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Clase.Listar());
        }

        

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Raza.Listar());
        }
    }
}
