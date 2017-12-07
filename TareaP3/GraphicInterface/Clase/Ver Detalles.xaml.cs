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

namespace GraphicInterface.Clase
{
    /// <summary>
    /// Lógica de interacción para Ver_Detalles.xaml
    /// </summary>
    public partial class Ver_Detalles : Page
    {
        public Ver_Detalles(int value)
        {
            InitializeComponent();
            values.Text = value.ToString();
            Domain.Clase Cx = BusinessLogic.ClaseBL.Obtener(value);
            TexNombre.Text = Cx.Nombre;
            TexDescripión.Text = Cx.Descripcion;
            if(BusinessLogic.HabilidadEspecialBL.Listar() != null)
            {
                List<Domain.Habilidad_Especial> LH = new List<Domain.Habilidad_Especial>();
                int IdC = Convert.ToInt32(values.Text);
                foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
                {
                    Domain.Clase_HE CH = BusinessLogic.Clase_HEBL.Obtener(IdC, H.Id);

                    if (CH != null)
                    {
                        LH.Add(H);
                    }
                }
                if (LH.Count == 0)
                {
                    MessageBox.Show("Esta clase no posee Habilidades en su colección");
                }
                listviewhab.ItemsSource = LH;
            }
           
        }

        private void Regresar_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
