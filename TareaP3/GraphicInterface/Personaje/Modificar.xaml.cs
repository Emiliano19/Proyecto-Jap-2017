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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Page
    {
        public Modificar(int value)
        {
            InitializeComponent();
           // this.RecibeId.Text = value;
            ComboRaza.ItemsSource = BusinessLogic.RazaBL.Listar();
            ComboRaza.SelectedValuePath = "IdRaza";
            ComboRaza.DisplayMemberPath = "Nombre";

            ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
            ComboClase.SelectedValuePath = "IdClase";
            ComboClase.DisplayMemberPath = "Nombre";

            RecibeId.Text = value.ToString();

            Domain.Personaje P = BusinessLogic.PersonajeBL.Obtener(Convert.ToInt32(value));

            if(Nombre.Text == "")
            {
                P.Nombre = NombreOrigiText.Text;
            }
            NivelViejo.Text = P.Nivel.ToString();
            RazaVieja.Text = P.RazaAtributo.Nombre;
            ClaseVieja.Text = P.ClaseAtributo.Nombre;
            FuerzaVieja.Text = P.Fuerza.ToString();
            DestrezaVieja.Text = P.Destreza.ToString();
            ConstiVieja.Text = P.Constitucion.ToString();
            InteliVieja.Text = P.Inteligencia.ToString();
            SabiduVieja.Text = P.Sabiduria.ToString();
            CarismaViejo.Text = P.Sabiduria.ToString();

            List<Domain.Caracteristica> Cc = new List<Domain.Caracteristica>();
            foreach(Domain.Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
            {
                Domain.Personaje_Caracteristica Pcc = BusinessLogic.Personaje_CaracteristicaBL.Obtener(value, C.Id);
                if(Pcc != null)
                {
                    Cc.Add(C);
                }
            }
            listviewcar.ItemsSource = Cc;

        }

        byte[] ImagenByte;
        BitmapDecoder bitCoder;


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Domain.Personaje P1 = BusinessLogic.PersonajeBL.Obtener(Convert.ToInt32(RecibeId.Text));
            int IdC;
            int IdR;
            IdC = BusinessLogic.PersonajeBL.RetornaClaseId(P1);
            IdR = BusinessLogic.PersonajeBL.RetornaRazaId(P1);

            if (Nombre.Text != "")
            {
                P1.Nombre = Nombre.Text;
            }
            else
            {
                P1.Nombre = NombreOrigiText.Text;
            }
            P1.Nivel = Convert.ToInt32(NivelViejo.Text);
            P1.Fuerza = Convert.ToInt32(FuerzaVieja.Text);
            P1.Destreza = Convert.ToInt32(DestrezaVieja.Text);
            P1.Constitucion = Convert.ToInt32(ConstiVieja.Text);
            P1.Inteligencia = Convert.ToInt32(InteliVieja.Text);
            P1.Sabiduria = Convert.ToInt32(SabiduVieja.Text);
            P1.Carisma = Convert.ToInt32(CarismaViejo.Text);
            if (ComboRaza.SelectedItem != null)
            {
                Domain.Raza selectItem = (Domain.Raza)ComboRaza.SelectedItem;
                IdR = selectItem.Id;
            }
            if(ComboClase.SelectedItem != null)
            {
                Domain.Clase selectItem = (Domain.Clase)ComboClase.SelectedItem;
                IdC = selectItem.Id;
            }
          
            int aux = BusinessLogic.PersonajeBL.Modificar(P1, IdR, IdC);

            if(aux == 1)
            {
                MessageBox.Show("Se a modificado correctamente su Personaje");
                MostrarCar.Visibility = Visibility.Visible;
            }
            else if(aux == -1)
            {
                MessageBox.Show("A Ocurrido un error y no se podido modificado correctamente su Personaje");
            }
            
        }

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

        private void ComboBoxNivel(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboNivel.SelectedIndex + 1;
            NivelViejo.Text = selectitem.ToString();
        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboFuerza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboFuerza.SelectedIndex + 1;
            FuerzaVieja.Text = selectitem.ToString();
        }

        private void ComboDestreza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboDestreza.SelectedIndex + 1;
            DestrezaVieja.Text = selectitem.ToString();
        }

        private void ComboConstitucion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboConstitucion.SelectedIndex + 1;
            ConstiVieja.Text = selectitem.ToString();
        }

        private void ComboInteligencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboInteligencia.SelectedIndex + 1;
            InteliVieja.Text = selectitem.ToString();
        }

        private void ComboSabiduria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboSabiduria.SelectedIndex + 1;
            SabiduVieja.Text = selectitem.ToString();
        }

        private void ComboCarisma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectitem = ComboCarisma.SelectedIndex + 1;
            CarismaViejo.Text = selectitem.ToString();
        }

        private void Nombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Navigation_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CargarValor.Visibility = Visibility.Visible;
            ValorCar.Visibility = Visibility.Visible;
            ComboCar.Visibility = Visibility.Visible;

        }

        private void CrearCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ComboRaza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
