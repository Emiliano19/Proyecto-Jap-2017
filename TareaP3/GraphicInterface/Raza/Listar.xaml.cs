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

namespace GraphicInterface.Raza
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            listview.ItemsSource = BusinessLogic.RazaBL.Listar();
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listview.SelectedItem != null)
            {
                Domain.Raza Rx = (Domain.Raza)listview.SelectedItem;
                int aux = BusinessLogic.RazaBL.Eliminar(Rx.Id);

                if(aux == 1)
                {
                    List<Domain.Raza> LR = new List<Domain.Raza>();
                    foreach(Domain.Raza R in BusinessLogic.RazaBL.Listar())
                    {
                        if(R.Id != Rx.Id)
                        {
                            LR.Add(R);
                        }
                    }
                    listview.ItemsSource = LR;
                    MessageBox.Show("Se a eliminado con Exito la Raza seleccionada");
                }
                else if(aux == -1)
                {
                    MessageBox.Show("A ocurrido un error inesperado a la hora de eliminar la Raza seleccionada");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una Raza de la lista antes de precionar Eliminar");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Domain.Raza R = (Domain.Raza)listview.SelectedItem;
            this.NavigationService.Navigate(new Modificar(R.Id));
        }

        private void Reagresar_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
