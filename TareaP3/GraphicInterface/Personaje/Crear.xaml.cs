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
            
            ComboRaza.ItemsSource = BusinessLogic.RazaBL.Listar();
            ComboRaza.SelectedValuePath = "IdRaza";
            ComboRaza.DisplayMemberPath = "Nombre";
     
            ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
            ComboClase.SelectedValuePath = "IdClase";
            ComboClase.DisplayMemberPath = "Nombre";

        }

        Domain.Personaje P = new Domain.Personaje();
        byte[] ImagenByte;
        BitmapDecoder bitCoder;
        int valor;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Hay que auto ajustar tamaño de la imagen a cuadro Image
            if (ImagenBuscar.Source == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                BitmapImage b = new BitmapImage();
                openFile.Title = "Seleccione la Imagen a Mostrar";
                openFile.Filter = "Todos(*.*) | *.*| Imagenes | *.jpg; *.gif; *.png; *.bmp";
                if (openFile.ShowDialog() == true)
                {
                    using (Stream stream = openFile.OpenFile())
                    {
                        bitCoder = BitmapDecoder.Create(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                        ImagenBuscar.Source = bitCoder.Frames[0];
                        RutaImagen.Text = openFile.FileName;
                    }
                }
            }
            else
            {
                ImagenBuscar.Source = null;
                Examinar.Content = "Agregar Foto";
            }
            System.IO.FileStream fs;
            fs = new System.IO.FileStream(RutaImagen.Text, System.IO.FileMode.Open);
            ImagenByte = new byte[Convert.ToInt32(fs.Length.ToString())];
            fs.Read(ImagenByte, 0, ImagenByte.Length);

        }

        private void Nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listviewcar.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
            if (P.Nombre == "" || P.Nivel == 0 || P.Fuerza == 0 || P.Destreza == 0 || P.Constitucion == 0 || P.Inteligencia == 0 || P.Sabiduria == 0 || P.Carisma == 0 || P.RazaAtributo == null || P.ClaseAtributo == null) //Falta agregar que la imagen no puede estar vacia
            {
                MessageBox.Show("Algun Campo a quedado vacío resive que este todo completo para poder guardar");
            }
            else
            {
                int aux = 0;
                if(BusinessLogic.PersonajeBL.Listar() != null)
                {
                    foreach (Domain.Personaje P1 in BusinessLogic.PersonajeBL.Listar())
                    {
                        if (P1.Nombre == Nombre.Text)
                        {
                            aux = aux + 1;
                            Nombre.Text = "";
                        }
                    }
                }
               
                if(aux == 1)
                {
                    MessageBox.Show("Ya existe un personaje con este nombre en la base de datos debe cambiarlo para poder guardar su nuevo Personaje");
                }
                else if(aux == 0)
                {
                    P.Nombre = Nombre.Text;
                    P.Imagen = ImagenByte;
                    int result = BusinessLogic.PersonajeBL.Agregar(P);
                    if (result == 1)
                    {
                        MessageBox.Show("Se guardado correctamente el nuevo Personaje");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado revise si ingreso los datos correctamente");
                    }
                }
            }
        }
        private void ComboRaza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComboRaza.SelectedIndex;
            Domain.Raza selectedItem = (Domain.Raza)ComboRaza.SelectedItem;
            P.RazaAtributo = selectedItem;
        }
        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComboClase.SelectedIndex;
            Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
            P.ClaseAtributo = selectedItem;
        }
        private void ComboBoxNivel(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboNivel.SelectedIndex + 1;
            P.Nivel = valor;
        }
        private void ComboFuerza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboFuerza.SelectedIndex + 1;
            P.Fuerza = valor;
        }
        private void ComboDestreza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboDestreza.SelectedIndex + 1;
            P.Destreza = valor;
        }
        private void ComboConstitucion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboConstitucion.SelectedIndex + 1;
            P.Constitucion = valor;
        }
        private void ComboInteligencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboInteligencia.SelectedIndex + 1;
            P.Inteligencia = valor;
        }
        private void ComboSabiduria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboSabiduria.SelectedIndex + 1;
            P.Sabiduria = valor;
        }
        private void ComboCarisma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valor = ComboCarisma.SelectedIndex + 1;
            P.Carisma = valor;
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AgregarC_Click(object sender, RoutedEventArgs e)
        {
          //  this.NavigationService.Navigate(new Característica.Crear());
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int IdP = BusinessLogic.PersonajeBL.Listar().Max(x => x.Id);
            int selectedIndex = listviewcar.SelectedIndex;
            Domain.Caracteristica selectedItem = (Domain.Caracteristica)listviewcar.SelectedItem;
            Domain.Personaje_Caracteristica aux = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, selectedItem.Id);
            if(aux != null)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("Prueba.jpg", UriKind.Relative);
                bi3.EndInit();
                ImagenTic.Stretch = Stretch.Fill;
                ImagenTic.Source = bi3;
            }
            else
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("PruebaX.jpg", UriKind.Relative);
                bi3.EndInit();
                ImagenTic.Stretch = Stretch.Fill;
                ImagenTic.Source = bi3;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int IdP = BusinessLogic.PersonajeBL.Listar().Max(x => x.Id);
            valor = ComboCarisma.SelectedIndex + 1;
            int selectedIndex = listviewcar.SelectedIndex;
            Domain.Caracteristica selectedItem = (Domain.Caracteristica)listviewcar.SelectedItem;
            int result = BusinessLogic.Personaje_CaracteristicaBL.Agregar(IdP, selectedItem.Id, valor);
        }
    }

}
