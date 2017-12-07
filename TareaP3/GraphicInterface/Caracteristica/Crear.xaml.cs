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
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Page
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void CrearCar_Click(object sender, RoutedEventArgs e)
        {
            if(Nombre.Text != "")
            {
                int valor = 1;
                Domain.Caracteristica C = new Domain.Caracteristica();
                C.Nombre = Nombre.Text;
                BusinessLogic.CaracteristicaBL.Agregar(C);
                int IdC = BusinessLogic.CaracteristicaBL.Listar().Max(x => x.Id);
                foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    BusinessLogic.Personaje_CaracteristicaBL.Agregar(P.Id, IdC, valor);
                }
                MessageBox.Show("Característica guardada con Exito");
                Nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar el Nombre para poder Guardar");
            }

        }

        private void Nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            Nombre.Text = "";
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            Nombre.Text = "";
        }

        private void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipal());
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
