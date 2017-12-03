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
using BusinessLogic;
using System.Configuration;
using System.Data;

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            listview.ItemsSource = BusinessLogic.PersonajeBL.Listar();
            foreach(Domain.Personaje P in listview.ItemsSource)
            {
                int IdR = BusinessLogic.PersonajeBL.RetornaRazaId(P);
                Domain.Raza R = BusinessLogic.RazaBL.Obtener(IdR);
                RazaName.Text = R.Nombre;
            }
            ComboPer.ItemsSource = BusinessLogic.PersonajeBL.Listar();
            ComboPer.SelectedValuePath = "IdPer";
            ComboPer.DisplayMemberPath = "Nombre";


            ComboRaza.ItemsSource = BusinessLogic.RazaBL.Listar();
            ComboRaza.SelectedValuePath = "IdRaza";
            ComboRaza.DisplayMemberPath = "Nombre";

            ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
            ComboClase.SelectedValuePath = "IdClase";
            ComboClase.DisplayMemberPath = "Nombre";

            
        }

        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listview.ItemsSource = BusinessLogic.PersonajeBL.Listar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BotonRaza_Click(object sender, RoutedEventArgs e)
        {
            if(ComboRaza.SelectedItem != null)
            {
                Domain.Raza selectedItem = (Domain.Raza)ComboRaza.SelectedItem;
                List<Domain.Personaje> PL = new List<Domain.Personaje>();
                foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    if (P.RazaAtributo.Id == selectedItem.Id)
                    {
                        PL.Add(P);
                    }
                }
                listview.ItemsSource = PL;
            }
            else
            {
                MessageBox.Show("Debe elegir una Raza antes de precionar Filtrado por Raza");
            }
        }

        private void BotonClase_Click(object sender, RoutedEventArgs e)
        {
            if (ComboClase.SelectedItem != null)
            {
                Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
                List<Domain.Personaje> PL = new List<Domain.Personaje>();
                foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    if (P.ClaseAtributo.Id == selectedItem.Id)
                    {
                        PL.Add(P);
                    }
                }
                listview.ItemsSource = PL;
            }
            else
            {
                MessageBox.Show("Debe elegir una Clase antes de precionar Filtrado por Clase");
            }
        }

        private void BotonDoble_Click(object sender, RoutedEventArgs e)
        {
            if (ComboRaza.SelectedItem != null && ComboClase.SelectedItem != null)
            {
                Domain.Raza selectedItemX = (Domain.Raza)ComboRaza.SelectedItem;
                List<Domain.Personaje> PLX = new List<Domain.Personaje>();
                foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    if (P.RazaAtributo.Id == selectedItemX.Id)
                    {
                        PLX.Add(P);
                    }
                }
                Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
                List<Domain.Personaje> PL = new List<Domain.Personaje>();
                foreach (Domain.Personaje P in PLX)
                {
                    if (P.ClaseAtributo.Id == selectedItem.Id)
                    {
                        PL.Add(P);
                    }
                }

                listview.ItemsSource = PL;
            }
            else
            {
                MessageBox.Show("Debe elegir una Raza y una Clase antes de precionar Filtrado doble");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Domain.Personaje selectItem = (Domain.Personaje)listview.SelectedItem;
           
        }

        private void Seleccionar_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(ComboPer.SelectedItem != null)
            {
                listview.Visibility = Visibility.Collapsed;
                Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
                this.Navigate1.Navigate(new Modificar(selectItem.Id));
            }
            else if(ComboPer.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Personaje del combobox antes de precionar Modificar");
            }
    
        }

        private void ComboPer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
            
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
            if(selectItem != null)
            {
                int result = BusinessLogic.PersonajeBL.Eliminar(selectItem.Id);
                if (result == 1)
                {
                    List<Domain.Personaje> PP = new List<Domain.Personaje>();
                    foreach (Domain.Personaje P in listview.ItemsSource)
                    {
                        if (P.Id != selectItem.Id)
                        {
                            PP.Add(P);
                        }

                    }
                    listview.ItemsSource = PP;
                    MessageBox.Show("Sea borrado el Personaje con Exito");
                }
                else if (result == -1)
                {
                    MessageBox.Show("A ocurrido algún error y no se a podido borrar el Personaje seleccionado");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Personaje de la lista antes de precionar Eliminar");
            }
           
        }

        private void Navigate_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }                
}
