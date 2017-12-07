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

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para Variables.xaml
    /// </summary>
    public partial class Variables : Page
    {
        public Variables(int value)
        {
            InitializeComponent();
            listviewcar.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
            IdPersonaje.Text = value.ToString();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPersonaje.Text);
            Domain.Caracteristica Cn = (Domain.Caracteristica)listviewcar.SelectedItem;
            Domain.Personaje_Caracteristica Pcc = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, Cn.Id);
            if(Pcc.valor < 15)
            {
                int valor = Pcc.valor + 1;
                int aux = BusinessLogic.Personaje_CaracteristicaBL.Modificar(IdP, Cn.Id, valor);

                if (aux == 1)
                {
                    MessageBox.Show("Se a modificado correctamente el valor de la Característica proceda a Finalizar");
                    listviewcar.ItemsSource = null;
                    this.NavigationService.GoBack();
                }
                else if (aux == -1)
                {
                    MessageBox.Show("A ocurrido un error inesperado al modificar el valor de la característica");
                }
            }
            else if(Pcc.valor == 15)
            {
                MessageBox.Show("El valor de esta Característica ya esta en el máximo permitido, elija otra");
            }

        }

    }

}
