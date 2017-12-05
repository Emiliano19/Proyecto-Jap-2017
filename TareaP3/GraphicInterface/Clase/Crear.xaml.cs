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
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Page
    {
        public Crear()
        {
            InitializeComponent();
            listviewHH.ItemsSource = BusinessLogic.HabilidadEspecialBL.Listar();
            listviewHH.Visibility = Visibility.Hidden;
            NombreH.Visibility = Visibility.Hidden;
            Instruciones.Visibility = Visibility.Hidden;
            Habitex.Visibility = Visibility.Hidden;
            Agregarx.Visibility = Visibility.Hidden;
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            Domain.Clase H = new Domain.Clase();

            if (TexNombre.Text != "" && TexDescripión.Text != "")
            {
                H.Nombre = TexNombre.Text;
                H.Descripcion = TexDescripión.Text;
                int cont = 0;
                foreach (Domain.Clase H1 in BusinessLogic.ClaseBL.Listar())
                {
                    if (H1.Nombre == H.Nombre || H1.Descripcion == H.Descripcion)
                    {
                        cont = cont + 1;
                    }
                }
                
                if(cont == 0)
                {
                    int result = BusinessLogic.ClaseBL.Agregar(H);

                    if (result == 1)
                    {
                        listviewHH.Visibility = Visibility.Visible;
                        NombreH.Visibility = Visibility.Visible;
                        Instruciones.Visibility = Visibility.Visible;
                        Habitex.Visibility = Visibility.Visible;
                        Agregarx.Visibility = Visibility.Visible;
                        MessageBox.Show("Se a guardado con exito la nueva Clase");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado al guardar la Clase");
                    }
                }
                else if(cont > 0)
                {
                    MessageBox.Show("Ya existe una Clase con ese Nombre en el Sistema");
                }
                
                
            }
            else
            {
                MessageBox.Show("Hay campos vacios debe completarlos todos para guardar");
            }
           
        }

        private void Agregax_Ckick(object sender, RoutedEventArgs e)
        {
            if(listviewHH.SelectedItem != null)
            {
                int IdC = BusinessLogic.ClaseBL.Listar().Max(x => x.Id);
                Domain.Clase C = BusinessLogic.ClaseBL.Obtener(IdC);
                Domain.Habilidad_Especial H = (Domain.Habilidad_Especial)listviewHH.SelectedItem;
                int aux = BusinessLogic.Clase_HEBL.Agregar(C, H);

                if (aux == 1)
                {
                    List<Domain.Habilidad_Especial> HL = new List<Domain.Habilidad_Especial>();
                    foreach(Domain.Habilidad_Especial HR in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Domain.Clase_HE XCH = BusinessLogic.Clase_HEBL.Obtener(IdC, HR.Id);
                        if(XCH == null)
                        {
                            HL.Add(HR);
                        }
                    }
                    listviewHH.ItemsSource = HL;
                    MessageBox.Show("Se le a cargado correctamente la Habilidad a su Clase escoja otra si lo descea");
                }
                if (aux == -1)
                {
                    MessageBox.Show("A Ocurrido un error inesperado");
                } 
            }
        }

        private void Finalizar_Ckick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void listviewHH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listviewHH.SelectedItem != null)
            {
                Domain.Habilidad_Especial H = (Domain.Habilidad_Especial)listviewHH.SelectedItem;
                NombreH.Text = H.Nombre;
            }
        }
    }
}
