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

namespace GraphicInterface.Habilidad
{
    /// <summary>
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Page
    {
        public Modificar(int value)
        {
            InitializeComponent();
            IdHabilidad.Text = value.ToString();
            Domain.Habilidad_Especial H = BusinessLogic.HabilidadEspecialBL.Obtener(Convert.ToInt32(IdHabilidad.Text));
            TexNombre.Text = H.Nombre;
            TexDescripión.Text = H.Descripcion;
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(TexNombre.Text != "" && TexDescripión.Text != "")
            {
                Domain.Habilidad_Especial H = BusinessLogic.HabilidadEspecialBL.Obtener(Convert.ToInt32(IdHabilidad.Text));
                H.Nombre = TexNombre.Text;
                H.Descripcion = TexDescripión.Text;
                int auz = BusinessLogic.HabilidadEspecialBL.Modificar(H);
                if(auz == 1)
                {
                    MessageBox.Show("Se a modificado correctamente la Habilidad");
                }
                else
                {
                    MessageBox.Show("A ocurrido un error inesperado al intentar modifcar la Habilidad");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios debe completar todo antes de guardar");
            }
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Listar());
        }
    }
}
