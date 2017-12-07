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

namespace GraphicInterface.Caracteristica
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            listview.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            listview.Width = 613;
            Guardar.Visibility = Visibility;
            NuevoNombre.Visibility = Visibility;
            NuevoNombreX.Visibility = Visibility;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Domain.Caracteristica selectedItem = (Domain.Caracteristica)listview.SelectedItem;
            if(selectedItem.Id != 7)
            {
                int result = BusinessLogic.CaracteristicaBL.Eliminar(selectedItem.Id);
                if(result == 1)
                {
                    List<Domain.Caracteristica> CC = new List<Domain.Caracteristica>();
                    foreach (Domain.Caracteristica C in listview.ItemsSource)
                    {
                        if (C.Id != selectedItem.Id)
                        {
                            CC.Add(C);
                        }

                    }
                    listview.ItemsSource = CC;
                    MessageBox.Show("Sea borrado la Característica con Exito");
                }
                else if(result == -1)
                {
                    MessageBox.Show("A ocurrido algún error y no se a podido borrar la Característica seleccionada");
                }
            }
            else if(selectedItem.Id == 7)
            {
                MessageBox.Show("No se puede eliminar esta Característica porque esta definida por defecto, elija otra");
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            Domain.Caracteristica selectItem = (Domain.Caracteristica)listview.SelectedItem;
            if(selectItem.Id != 7)
            {
                selectItem.Nombre = NuevoNombreX.Text;
                int result = BusinessLogic.CaracteristicaBL.Modificar(selectItem);
                if (result == 1)
                {
                    NuevoNombre.Visibility = Visibility.Hidden;
                    NuevoNombreX.Visibility = Visibility.Hidden;
                    Guardar.Visibility = Visibility.Hidden;
                    NuevoNombreX.Text = "";
                    listview.Width = 972;
                    MessageBox.Show("La Característica se a modificado con Exito");
                    listview.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
                }
                else if (result == -1)
                {
                    MessageBox.Show("A ocurrido algún error y no se a podido modificar la Característica seleccionada");
                }
            }
            else if (selectItem.Id == 7)
            {
                MessageBox.Show("No se puede modificar esta Característica porque esta definida por defecto, elija otra");
                NuevoNombre.Visibility = Visibility.Hidden;
                NuevoNombreX.Visibility = Visibility.Hidden;
                Guardar.Visibility = Visibility.Hidden;
                NuevoNombreX.Text = "";
                listview.Width = 972;
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipal());
        }
    }
}
