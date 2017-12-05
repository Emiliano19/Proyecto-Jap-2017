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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Page
    {
        public Modificar(int value)
        {
            InitializeComponent();
            IdRaza.Text = value.ToString();
            Domain.Raza Rx = BusinessLogic.RazaBL.Obtener(value);

            TexNombre.Text = Rx.Nombre;
            TexDescripión.Text = Rx.Descripcion;
            Caracteristica.Text = Rx.Caract_VarRazaAtributo.Nombre;
            ValorPlus.Text = Rx.ValorPlus.ToString();
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if(TexNombre.Text == "" || TexDescripión.Text == "")
            {
                MessageBox.Show("Hay campos vacios serciorese de que estan todos completos antes de guardar");
            }
            else
            {
                Domain.Raza Rz = BusinessLogic.RazaBL.Obtener(Convert.ToInt32(IdRaza.Text));
                if (ComboCar.SelectedItem != null)
                {
                    Domain.Caracteristica Cx = (Domain.Caracteristica)ComboCar.SelectedItem;
                    Rz.Caract_VarRazaAtributo = Cx;
                }
                if (ComboValor.SelectedItem != null)
                {
                    Rz.ValorPlus = ComboValor.SelectedIndex + 1;
                }
                else
                {
                    Rz.ValorPlus = Convert.ToInt32(ValorPlus.Text);
                }
                Rz.Nombre = TexNombre.Text;
                Rz.Descripcion = TexDescripión.Text;
                if(ComboCar.SelectedItem == null)
                {
                    int Idc = Rz.Caract_VarRazaAtributo.Id;
                    int aux = BusinessLogic.RazaBL.Modificar(Rz, Idc);
                }
                else
                {
                    Domain.Caracteristica Cx = (Domain.Caracteristica)ComboCar.SelectedItem;
                    int aux = BusinessLogic.RazaBL.Modificar(Rz, Cx.Id);

                    if(aux == 1)
                    {
                        MessageBox.Show("Se a modificado correctamente la Raza");
                    }
                    else if(aux == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado al intentar modificar la Raza");
                    }
                }
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void ComboValor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
