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
            if (Nombre.Text == "" || P.Nivel == 0 || P.Fuerza == 0 || P.Destreza == 0 || P.Constitucion == 0 || P.Inteligencia == 0 || P.Sabiduria == 0 || P.Carisma == 0 || P.RazaAtributo == null || P.ClaseAtributo == null || ImagenBuscar.Source == null) //Falta agregar que la imagen no puede estar vacia
            {
                if(P.Nombre == "")
                {
                    MessageBox.Show("Falta ingresar el Nombre");
                }
                else if (P.Nivel == 0)
                {
                    MessageBox.Show("Falta ingresar el Nivel");
                }
                else if (P.Fuerza == 0)
                {
                    MessageBox.Show("Falta ingresar la Fuerza");
                }
                else if (P.Destreza == 0)
                {
                    MessageBox.Show("Falta ingresar la Destreza");
                }
                else if (P.Constitucion == 0)
                {
                    MessageBox.Show("Falta ingresar la Constitución");
                }
                else if (P.Inteligencia == 0)
                {
                    MessageBox.Show("Falta ingresar la Inteligencia");
                }
                else if (P.Sabiduria == 0)
                {
                    MessageBox.Show("Falta ingresar la Sabiduria");
                }
                else if (P.Carisma == 0)
                {
                    MessageBox.Show("Falta ingresar el Carisma");
                }
                else if(P.Imagen == null)
                {
                    MessageBox.Show("Falta ingresar la Imagen");
                }
        
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
                        MostrarCar.Visibility = Visibility;
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
            int IdP = BusinessLogic.PersonajeBL.Listar().Max(x => x.Id);
            int cont = 0;
            foreach (Domain.Caracteristica CX in BusinessLogic.CaracteristicaBL.Listar())
            {
                Domain.Personaje_Caracteristica PX = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, CX.Id);
                if (PX != null)
                {
                    cont = cont + 1;
                }
            }
            if (cont == BusinessLogic.CaracteristicaBL.Listar().Count)
            {
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("No se puede Cancelar sin darle valor a las Características de su personaje");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new Caracteristicas());
            CrearCar.Visibility = Visibility;
        }

        private void Navigation_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void CrearCar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Caracteristica.Crear());
        }
    }

}
