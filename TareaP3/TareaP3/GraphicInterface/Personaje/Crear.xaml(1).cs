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
using System.Data;
using System.Configuration;
using Microsoft.Win32;
using System.IO;

namespace GraphicInterface.Personaje
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

        Domain.Personaje P = new Domain.Personaje();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ImagenBuscar.Source == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                BitmapImage b = new BitmapImage();
                openFile.Title = "Seleccione la Imagen a Mostrar";
                openFile.Filter = "Todos(*.*) | *.*| Imagenes | *.jpg; *.gif; *.png; *.bmp";
                if (openFile.ShowDialog() == true)
                {
                    b.BeginInit();
                    b.UriSource = new Uri(openFile.FileName);//base64 para pasar imagenes a la bd... 
                    b.EndInit();
                    ImagenBuscar.Stretch = Stretch.Fill;
                    ImagenBuscar.Source = b;

                    Examinar.Content = "Examinar";
                }
            }
            else
            {
                ImagenBuscar.Source = null;
                Examinar.Content = "Agregar Foto";
            }
        }

        private void Nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            P.Nombre = Nombre.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            P.Nivel = int.Parse(TexNivel.Text);
            BusinessLogic.PersonajeBL.Agregar(P);
        }

        //Nivel
        private void Nivel1(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "1";
        }
        private void Nivel2(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "2";
        }
        private void Nivel3(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "3";
        }
        private void Nivel4(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "4";
        }
        private void Nivel5(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "5";
        }
        private void Nivel6(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "6";
        }
        private void Nivel7(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "7";
        }
        private void Nivel8(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "8";
        }
        private void Nivel9(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "9";
        }
        private void Nivel10(object sender, RoutedEventArgs e)
        {
            TexNivel.Text = "10";
        }

        //Fuerza
    }
}
