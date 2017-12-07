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
            Domain.Personaje P = BusinessLogic.PersonajeBL.Obtener(value);
            FuerzaValor.Text = P.Fuerza.ToString();
            DestrezaValor.Text = P.Destreza.ToString();
            ConstValor.Text = P.Constitucion.ToString();
            InteliValor.Text = P.Inteligencia.ToString();
            SabiduriaValor.Text = P.Sabiduria.ToString();
            CarismaValor.Text = P.Carisma.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if(Per.Fuerza < 15)
            {
                Per.Fuerza = Per.Fuerza + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza fue aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if(Per.Fuerza == 15)
            {
                MessageBox.Show("El valor de Fuerza ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if (Per.Destreza < 15)
            {
                Per.Destreza = Per.Destreza + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza a aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if (Per.Destreza == 15)
            {
                MessageBox.Show("El valor de Fuerza ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if (Per.Constitucion < 15)
            {
                Per.Constitucion = Per.Constitucion + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza a aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if (Per.Constitucion == 15)
            {
                MessageBox.Show("El valor de Fuerza ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if (Per.Inteligencia < 15)
            {
                Per.Inteligencia = Per.Inteligencia + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza a aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if (Per.Inteligencia == 15)
            {
                MessageBox.Show("El valor de Inteligencia ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if (Per.Sabiduria < 15)
            {
                Per.Sabiduria = Per.Sabiduria + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza a aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if (Per.Sabiduria == 15)
            {
                MessageBox.Show("El valor de Sabiduría ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }
           
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int IdP = Convert.ToInt32(IdPER.Text);
            Domain.Personaje Per = BusinessLogic.PersonajeBL.Obtener(IdP);
            if (Per.Carisma < 15)
            {
                Per.Carisma = Per.Carisma + 1;
                int IdR = Per.RazaAtributo.Id;
                int IdC = Per.ClaseAtributo.Id;
                int aux = BusinessLogic.PersonajeBL.Modificar(Per, IdR, IdC);
                if (aux == 1)
                {
                    MessageBox.Show("El valor de Fuerza a aumentado con Exito");
                    FuerzaValor.Visibility = Visibility.Hidden;
                    DestrezaValor.Visibility = Visibility.Hidden;
                    ConstValor.Visibility = Visibility.Hidden;
                    InteliValor.Visibility = Visibility.Hidden;
                    SabiduriaValor.Visibility = Visibility.Hidden;
                    CarismaValor.Visibility = Visibility.Hidden;

                    Fuerza.Visibility = Visibility.Hidden;
                    Destreza.Visibility = Visibility.Hidden;
                    Consti.Visibility = Visibility.Hidden;
                    Inteligencia.Visibility = Visibility.Hidden;
                    Sabiduria.Visibility = Visibility.Hidden;
                    Carisma.Visibility = Visibility.Hidden;

                }
            }
            else if (Per.Carisma == 15)
            {
                MessageBox.Show("El valor de Carisma ya esta en el Máximo permitido, elija otra Característica para aumentar");
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipal());
        }
    }
}
