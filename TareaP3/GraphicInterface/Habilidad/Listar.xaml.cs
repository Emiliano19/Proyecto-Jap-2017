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
            listview.ItemsSource = BusinessLogic.HabilidadEspecialBL.Listar();
            ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
            ComboClase.SelectedValuePath = "IdClase";
            ComboClase.DisplayMemberPath = "Nombre";
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComboClase.SelectedIndex;
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
           
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
