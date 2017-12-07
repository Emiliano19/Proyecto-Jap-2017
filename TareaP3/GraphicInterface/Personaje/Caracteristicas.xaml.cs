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
using Microsoft.Win32;
using System.IO;

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para Caracteristicas.xaml
    /// </summary>
    public partial class Caracteristicas : Page
    {
        public Caracteristicas(int value)
        {
            InitializeComponent();
            listviewcar.ItemsSource = BusinessLogic.CaracteristicaBL.Listar();
            IdPersonaje.Text = value.ToString();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int IdP = BusinessLogic.PersonajeBL.Listar().Max(x => x.Id);
            int cont = 1;
            foreach (Domain.Caracteristica CX in BusinessLogic.CaracteristicaBL.Listar())
            {
                Domain.Personaje_Caracteristica PX = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, CX.Id);
                if (PX != null)
                {
                    cont = cont + 1;
                }
            }
            if (listviewcar.SelectedItem != null)
            {
                int valor = ComboCar.SelectedIndex + 1;
                if(valor != 0)
                {
                    int selectedIndex = listviewcar.SelectedIndex;
                    Domain.Caracteristica selectedItem = (Domain.Caracteristica)listviewcar.SelectedItem;
                    Domain.Personaje_Caracteristica P = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, selectedItem.Id);
                    if (P != null)
                    {
                        MessageBox.Show("Esta Característica ya posee un valor para este Personaje");
                    }
                    else if(P == null)
                    {
                        int result = BusinessLogic.Personaje_CaracteristicaBL.Agregar(IdP, selectedItem.Id, valor);
                        List<Domain.Caracteristica> CC = new List<Domain.Caracteristica>();
                        foreach (Domain.Caracteristica C in listviewcar.ItemsSource)
                        {
                            if (C.Id != selectedItem.Id)
                            {
                                CC.Add(C);
                            }

                        }
                        listviewcar.ItemsSource = CC;
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar algún valor antes de precionar cargar");
                }

            }
            if (cont == BusinessLogic.CaracteristicaBL.Listar().Count)
            {
                MessageBox.Show("Se an cargado correctamente los valores a todas las Características");
                Domain.Personaje Px = BusinessLogic.PersonajeBL.Obtener(Convert.ToInt32(IdPersonaje.Text));
                int IdR = Px.RazaAtributo.Id;
                Domain.Raza Rx = BusinessLogic.RazaBL.Obtener(IdR);
                int IdCa = Rx.Caract_VarRazaAtributo.Id;

                Domain.Personaje_Caracteristica PCx = BusinessLogic.Personaje_CaracteristicaBL.Obtener(IdP, IdCa);
                int valor = PCx.valor + Rx.ValorPlus;
                BusinessLogic.Personaje_CaracteristicaBL.Modificar(IdP, IdCa, valor);
                listviewcar.ItemsSource = null;
            }
        }

        private void CrearCar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Caracteristica.Crear());
        }
    }
}
