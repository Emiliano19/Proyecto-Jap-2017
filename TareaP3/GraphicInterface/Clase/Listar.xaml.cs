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

namespace GraphicInterface.Clase
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            listview.ItemsSource = BusinessLogic.ClaseBL.Listar();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                Domain.Clase C = (Domain.Clase)listview.SelectedItem;
                int aux = BusinessLogic.ClaseBL.Eliminar(C.Id);

                if(aux == 1)
                {
                    List<Domain.Clase> LC = new List<Domain.Clase>();
                    foreach(Domain.Clase CZ in BusinessLogic.ClaseBL.Listar())
                    {
                        LC.Add(CZ);
                    }
                    listview.ItemsSource = LC;
                    MessageBox.Show("Se a borrado la Clase con Exito");
                }
                else if (aux == -1)
                {
                    MessageBox.Show("A ocurrido un error inesperado y no se a podido borrar la Clase seleccionada");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase de la lista para poder eliminarla");
            }
        }

        private void detalles_Click_2(object sender, RoutedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                Domain.Clase C = (Domain.Clase)listview.SelectedItem;
                this.NavigationService.Navigate(new Ver_Detalles(C.Id));
            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase de la lista para poder Ver Detalles");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (listview.SelectedItem != null)
            {
                Domain.Clase C = (Domain.Clase)listview.SelectedItem;
                this.NavigationService.Navigate(new Modificar(C.Id));
            }
            else
            {
                MessageBox.Show("Debe seleccionar una clase de la lista para poder Modificar");
            }
        }

        private void Reagresar_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
