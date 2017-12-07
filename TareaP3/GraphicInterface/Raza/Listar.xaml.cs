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
            if (BusinessLogic.RazaBL.Listar() != null)
            {
                listview.ItemsSource = BusinessLogic.RazaBL.Listar();
            }
            else
            {
                MessageBox.Show("No hay Razas para mostrar en el sistema debe crear algunos antes de listar");
            }
        
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.RazaBL.Listar() != null)
            {
                if (listview.SelectedItem != null)
                {
                    Domain.Raza Rx = (Domain.Raza)listview.SelectedItem;
                    int aux = BusinessLogic.RazaBL.Eliminar(Rx.Id);

                    if (aux == 1)
                    {
                        List<Domain.Raza> LR = new List<Domain.Raza>();
                        foreach (Domain.Raza R in BusinessLogic.RazaBL.Listar())
                        {
                            if (R.Id != Rx.Id)
                            {
                                LR.Add(R);
                            }
                        }
                        listview.ItemsSource = LR;
                        MessageBox.Show("Se a eliminado con Exito la Raza seleccionada");
                    }
                    else if (aux == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado a la hora de eliminar la Raza seleccionada");
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una Raza de la lista antes de precionar Eliminar");
                }
            }
            else
            {
                MessageBox.Show("No hay Razas en el sistema así que no se puede Eliminar");
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.RazaBL.Listar() != null)
            {
                if(listview.SelectedItem != null)
                {
                    Domain.Raza R = (Domain.Raza)listview.SelectedItem;
                    this.NavigationService.Navigate(new Modificar(R.Id));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una Raza de la lista antes de precinar Modificar");
                }
            }
            else
            {
                MessageBox.Show("No hay Razas en el sistema así que no se puede Modificar");
            }
           
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
