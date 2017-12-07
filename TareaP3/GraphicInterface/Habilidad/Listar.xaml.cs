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

namespace GraphicInterface.Habilidad
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            if(BusinessLogic.HabilidadEspecialBL.Listar() != null)
            {
                listview.ItemsSource = BusinessLogic.HabilidadEspecialBL.Listar();
            }
            else
            {
                MessageBox.Show("No hay Habilidades quer mostrar en el sistema");
            }
            if(BusinessLogic.ClaseBL.Listar() != null)
            {
                ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
                ComboClase.SelectedValuePath = "IdClase";
                ComboClase.DisplayMemberPath = "Nombre";
            }
    
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
            List<Domain.Habilidad_Especial> HL = new List<Domain.Habilidad_Especial>();
            foreach(Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
            {
                Domain.Clase_HE CH = BusinessLogic.Clase_HEBL.Obtener(selectedItem.Id, H.Id);
                if(CH != null)
                {
                    HL.Add(H);
                }
            }
            listview.ItemsSource = HL;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                Domain.Habilidad_Especial aux = (Domain.Habilidad_Especial)listview.SelectedItem;
                this.NavigationService.Navigate(new Modificar(aux.Id));
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Habilidad de la lista antes de precionar Modificar");
            }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(listview.SelectedItem != null)
            {
                Domain.Habilidad_Especial Y = (Domain.Habilidad_Especial)listview.SelectedItem;
                int result = BusinessLogic.HabilidadEspecialBL.Eliminar(Y.Id);

                if(result == 1)
                {
                    List<Domain.Habilidad_Especial> LH = new List<Domain.Habilidad_Especial>();
                    if(BusinessLogic.HabilidadEspecialBL.Listar() != null)
                    {
                        foreach(Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
                        {
                            LH.Add(H);
                        }
                        listview.ItemsSource = LH;
                    }
                    else
                    {
                        listview.ItemsSource = null;
                    }
                    MessageBox.Show("Se a borrado exitosamente la Habilidad");
                }
                else
                {
                    MessageBox.Show("A ocurrido un error inesperado al intentar Eliminar la Habilidad");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Habilidad de la lista antes de precionar Eliminar");
            }
            
        }

        private void Button_Click_x(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
