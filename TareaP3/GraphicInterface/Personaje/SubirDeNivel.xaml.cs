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
        public Subir_de_Nivel(int value)
        {
            InitializeComponent();
            IdPersonaje.Text = value.ToString();
            Domain.Personaje Px = BusinessLogic.PersonajeBL.Obtener(value);
            TexNombre.Text = Px.Nombre;
            TexId.Text = Px.Id.ToString();
            int IdC = Px.ClaseAtributo.Id;
            List<Domain.Habilidad_Especial> HL = new List<Domain.Habilidad_Especial>();
            foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
            {
                Domain.Clase_HE CH = BusinessLogic.Clase_HEBL.Obtener(IdC, H.Id);
                if(CH != null)
                {
                    Domain.Personaje_HE auz = BusinessLogic.Personaje_HEBL.Obtener(Px.Id, H.Id);
                    if(auz == null)
                    {
                        HL.Add(H);
                    }
                }
            }
            listview.ItemsSource = HL;
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
            if (listview.SelectedItem != null)
            {
                int IdP = Convert.ToInt32(IdPersonaje.Text);
                Domain.Personaje PZ = BusinessLogic.PersonajeBL.Obtener(IdP);
                Domain.Habilidad_Especial HY = (Domain.Habilidad_Especial)listview.SelectedItem;
                BusinessLogic.Personaje_HEBL.Agregar(IdP, HY.Id);
                int aux = 0;
                if(PZ.Nivel != 1)
                {
                    aux = PZ.Nivel % 2;
                }

                if(aux == 0 || PZ.Nivel == 1)
                {
                    Finalizar.Visibility = Visibility.Visible;
                    int IdR = PZ.RazaAtributo.Id;
                    int IdC = PZ.ClaseAtributo.Id;
                    PZ.Nivel = PZ.Nivel + 1;
                    BusinessLogic.PersonajeBL.Modificar(PZ, IdR, IdC);
                    MessageBox.Show("El Nivel de su Personaje es par asi que solo agregarle Habilidades y no Aumenta el valor de las Características");
                }
                else
                {
                    int IdR = PZ.RazaAtributo.Id;
                    int IdC = PZ.ClaseAtributo.Id;
                    PZ.Nivel = PZ.Nivel + 1;
                    BusinessLogic.PersonajeBL.Modificar(PZ, IdR, IdC);
                    Fijass.Visibility = Visibility.Visible;
                    Variabless.Visibility = Visibility.Visible;
                    Mensaje.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Habilidad antes de agregar al Personaje");
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
        }

        private void Fijass_Click(object sender, RoutedEventArgs e)
        {
            Navigate.Visibility = Visibility.Visible;
            this.Navigate.Navigate(new Variables(Convert.ToInt32(IdPersonaje.Text)));
        }

        private void Finalizar_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
