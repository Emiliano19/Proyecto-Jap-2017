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
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Page
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(TexNombre.Text != "" && TexDescripión.Text != "")
            {
                Domain.Habilidad_Especial H = new Domain.Habilidad_Especial();

                H.Nombre = TexNombre.Text;
                H.Descripcion = TexDescripión.Text;
                int cont = 0;

                foreach (Domain.Habilidad_Especial H1 in BusinessLogic.HabilidadEspecialBL.Listar())
                {
                    if (H1.Nombre == H.Nombre || H1.Descripcion == H.Descripcion)
                    {
                        MessageBox.Show("Ya existe una habilidad con ese Nombre o Descripción en el sistema");
                        cont = cont + 1;
                        TexNombre.Text = "";
                        TexDescripión.Text = "";
                    }
                }

                if (cont == 0)
                {

                    int result = BusinessLogic.HabilidadEspecialBL.Agregar(H);

                    if (result == 1)
                    {
                        MessageBox.Show("Se a guardado con exito la nueva Habilidad");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado al intentar guardar la habilidad");
                    }
                    TexNombre.Text = "";
                    TexDescripión.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios debe completarlos para poder guardar");
            }
           
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
