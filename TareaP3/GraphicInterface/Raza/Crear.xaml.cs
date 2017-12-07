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

namespace GraphicInterface.Raza
{
    /// <summary>
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Page
    {
        public Crear()
        {
            InitializeComponent();
            ComboCar.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
            ComboCar.SelectedValuePath = "IdCar";
            ComboCar.DisplayMemberPath = "Nombre";

        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            Domain.Raza H = new Domain.Raza();

            if(TexNombre.Text != "" && TexDescripión.Text != "" && ComboCar.SelectedItem != null && ComboValor.SelectedItem != null)
            {
                int cont = 0;

                foreach (Domain.Raza H1 in BusinessLogic.RazaBL.Listar())
                {
                    if (H1.Nombre == H.Nombre || H1.Descripcion == H.Descripcion)
                    {
                        MessageBox.Show("Ya existe una Raza con ese Nombre o Descripción en el sistema");
                        cont = cont + 1;
                        TexNombre.Text = "";
                        TexDescripión.Text = "";
                    }
                }

                if (cont == 0)
                {
                    H.Nombre = TexNombre.Text;
                    H.Descripcion = TexDescripión.Text;
                    if (ComboCar.SelectedItem != null)
                    {
                        H.Caract_VarRazaAtributo = (Domain.Caracteristica)ComboCar.SelectedItem;
                    }
                    if (ComboValor.SelectedItem != null)
                    {
                        H.ValorPlus = ComboValor.SelectedIndex + 1;
                    }
                    int result = BusinessLogic.RazaBL.Agregar(H);

                    if (result == 1)
                    {
                        MessageBox.Show("Se a guardado con exito la nueva Raza");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("A ocurrido un error, asegurese de que ningún campo quede vacio");
                    }
                    TexNombre.Text = "";
                    TexDescripión.Text = "";
                    ComboCar.SelectedItem = null;
                    ComboValor.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("A quedado algun campo vacio revise denuevo antes de guardar");
            }
           
        }

        private void ComboCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboValor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
