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
    /// Lógica de interacción para Subir_de_Nivel.xaml
    /// </summary>
    public partial class Subir_de_Nivel : Page
    {
        public Subir_de_Nivel(int value, int nivel)
        {
            InitializeComponent();
            NivelRecibido.Text = nivel.ToString();
            IdPersonaje.Text = value.ToString();
            Domain.Personaje Px = BusinessLogic.PersonajeBL.Obtener(value);
            TexNombre.Text = Px.Nombre;
            TexId.Text = Px.Id.ToString();
            int IdC = Px.ClaseAtributo.Id;
            List<Domain.Habilidad_Especial> HL = new List<Domain.Habilidad_Especial>();
            List<Domain.Habilidad_Especial> Hll = new List<Domain.Habilidad_Especial>();
            List<Domain.Habilidad_Especial> aux = new List<Domain.Habilidad_Especial>();
            foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
            {
                Domain.Clase_HE HC = BusinessLogic.Clase_HEBL.Obtener(IdC, H.Id);

                if (HC != null)
                {
                    Hll.Add(H);
                }
            }
            foreach (Domain.Habilidad_Especial H in Hll)
            { 
                Domain.Personaje_HE HP = BusinessLogic.Personaje_HEBL.Obtener(value, H.Id);

                if (HP == null)
                {
                    HL.Add(H);
                }
                else if(HP != null)
                {
                    aux.Add(H);
                }
     
            }
            if (aux.Count != Hll.Count)
            {
                listview.ItemsSource = HL;
            }
            else if(aux.Count == Hll.Count)
            {
                MensajeNivel.Visibility = Visibility.Visible;
                AgregarH.Visibility = Visibility.Hidden;
                NombreHabili.Visibility = Visibility.Hidden;
                Fijass.Visibility = Visibility.Visible;
                Variabless.Visibility = Visibility.Visible;
                Mensaje.Visibility = Visibility.Visible;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                Domain.Habilidad_Especial HY = (Domain.Habilidad_Especial)listview.SelectedItem;
                NombreHabili.Text = HY.Nombre;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool subio = false;
            if (listview.SelectedItem != null)
            {
                int IdP = Convert.ToInt32(IdPersonaje.Text);
                Domain.Personaje PZ = BusinessLogic.PersonajeBL.Obtener(IdP);
                Domain.Habilidad_Especial HY = (Domain.Habilidad_Especial)listview.SelectedItem;
                BusinessLogic.Personaje_HEBL.Agregar(IdP, HY.Id);

                int Nivel = Convert.ToInt32(NivelRecibido.Text);
                int aux = 0;
                if(Nivel != 1)
                {
                    aux = Nivel % 2;
                }

                if(aux == 0 || PZ.Nivel == 1)
                {
                    subio = true;
                    listview.ItemsSource = null;
                    Finalizar.Visibility = Visibility.Visible;
                    MessageBox.Show("Se a cargado la Habilidad pero el Nivel de su Personaje es par asi que solo agregarle Habilidades y no Aumenta el valor de las Características");
                    this.NavigationService.Navigate(new Listar());
                }
                else
                {
                    subio = true;
                    listview.ItemsSource = null;
                    Fijass.Visibility = Visibility.Visible;
                    Variabless.Visibility = Visibility.Visible;
                    Mensaje.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Habilidad antes de agregar al Personaje");
            }

            if (subio)
            {
                AgregarH.Visibility = Visibility.Hidden;
                NombreHabili.Visibility = Visibility.Hidden;
            }
        }

        private void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Navigate.Visibility = Visibility.Visible;
            this.NavigationService.Navigate(new Fijas(Convert.ToInt32(IdPersonaje.Text)));
            Fijass.Visibility = Visibility.Hidden;
            Variabless.Visibility = Visibility.Hidden;
        }

        private void Fijass_Click(object sender, RoutedEventArgs e)
        {
            Navigate.Visibility = Visibility.Visible;
            this.Navigate.Navigate(new Variables(Convert.ToInt32(IdPersonaje.Text)));
            Fijass.Visibility = Visibility.Hidden;
            Variabless.Visibility = Visibility.Hidden;
        }

        private void Finalizar_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipal());
        }
    }
}
