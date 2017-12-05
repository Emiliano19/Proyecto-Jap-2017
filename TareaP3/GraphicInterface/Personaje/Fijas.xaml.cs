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
    /// Lógica de interacción para Fijas.xaml
    /// </summary>
    public partial class Fijas : Page
    {
        public Fijas(int value)
        {
            InitializeComponent();
            IdPER.Text = value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Fuerza = Per.Fuerza + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if(aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Destreza = Per.Destreza + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if (aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Constitucion = Per.Constitucion + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if (aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Inteligencia = Per.Inteligencia + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if (aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Sabiduria = Per.Sabiduria + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if (aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            Per.Carisma = Per.Carisma + 1;
            int IdR = Per.RazaAtributo.Id;
            int IdC = Per.ClaseAtributo.Id;
            int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
            if (aux == 1)
            {
                MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                Fuerza.Visibility = Visibility.Hidden;
                Destreza.Visibility = Visibility.Hidden;
                Consti.Visibility = Visibility.Hidden;
                Inteligencia.Visibility = Visibility.Hidden;
                Sabiduria.Visibility = Visibility.Hidden;
                Carisma.Visibility = Visibility.Hidden;

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
