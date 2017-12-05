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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Page
    {
        public Modificar(int value)
        {
            InitializeComponent();
            IdRecibido.Text = value.ToString();
            if (BusinessLogic.HabilidadEspecialBL.Listar() != null)
            {
                int Idc = Convert.ToInt32(IdRecibido.Text);
                List<Domain.Habilidad_Especial> HL = new List<Domain.Habilidad_Especial>();
                List<Domain.Habilidad_Especial> HLS = new List<Domain.Habilidad_Especial>();
                foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
                {
                    Domain.Clase_HE CH = BusinessLogic.Clase_HEBL.Obtener(Idc, H.Id);
                    if (CH != null)
                    {
                        HL.Add(H);
                    }
                    else
                    {
                        HLS.Add(H);
                    }
                }
                listviewHdeC.ItemsSource = HL;
                listviewHSistema.ItemsSource = HLS;
            }
            Domain.Clase Caux = BusinessLogic.ClaseBL.Obtener(value);
            TexNombre.Text = Caux.Nombre;
            TexDescripión.Text = Caux.Descripcion;
        }

        private void Guardar(object sender, RoutedEventArgs e)
        {
            int Idc = Convert.ToInt32(IdRecibido.Text);
            Domain.Clase Caux = BusinessLogic.ClaseBL.Obtener(Idc);

            if (TexNombre.Text != "" && TexDescripión.Text != "")
            {
                Caux.Nombre = TexNombre.Text;
                Caux.Descripcion = TexDescripión.Text;
                int result = BusinessLogic.ClaseBL.Agregar(Caux);

                if (result == 1)
                {
                    MessageBox.Show("La Clase se a modificado con Exito");
                }
                else if (result == -1)
                {
                    MessageBox.Show("A ocurrido un error inesperado y no se a podido guardar la modificación");
                }
               
            }
            else
            {
                MessageBox.Show("Hay Campos vacios debe completarlos todos");
            }
        }

        private void VolveraListar_Ckick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void AgregaraC(object sender, RoutedEventArgs e)
        {
            if (listviewHSistema.SelectedItem != null)
            {
                int IdC = Convert.ToInt32(IdRecibido.Text);
                Domain.Habilidad_Especial H = (Domain.Habilidad_Especial)listviewHSistema.SelectedItem;
                Domain.Clase C = BusinessLogic.ClaseBL.Obtener(IdC);
                List<Domain.Habilidad_Especial> LH = new List<Domain.Habilidad_Especial>();
                
                int aux = BusinessLogic.Clase_HEBL.Agregar(C, H);
                if (aux == -1)
                {
                    MessageBox.Show("A ocurrido un error inesperado al intentar cargarle la Habilidad a la Clase");
                }
                else
                {
                    foreach (Domain.Habilidad_Especial H1 in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Domain.Clase_HE CH = BusinessLogic.Clase_HEBL.Obtener(IdC, H1.Id);
                        if (CH != null)
                        {
                            LH.Add(H1);
                        }
                      
                    }
                    listviewHdeC.ItemsSource = LH;

                    List<Domain.Habilidad_Especial> HY = new List<Domain.Habilidad_Especial>();
                    foreach (Domain.Habilidad_Especial HV in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Domain.Clase_HE CY = BusinessLogic.Clase_HEBL.Obtener(IdC, HV.Id);
                        if (CY == null)
                        {
                            HY.Add(HV);
                        }
                    }
                    listviewHSistema.ItemsSource = HY;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Habilidad de la lista antes de precionar Agregar");
            }
        }

        private void EliminarDeC_Ckick(object sender, RoutedEventArgs e)
        {
            if(listviewHdeC == null)
            {
                MessageBox.Show("La Clase no posee Habilidades para eliminar");
            }
            else
            {
                if(listviewHdeC.SelectedItem != null)
                {
                    int IdC = Convert.ToInt32(IdRecibido.Text);
                    Domain.Habilidad_Especial H = (Domain.Habilidad_Especial)listviewHdeC.SelectedItem;
                    List<Domain.Habilidad_Especial> HHH = new List<Domain.Habilidad_Especial>();

                    int aux = BusinessLogic.Clase_HEBL.Eliminar(IdC, H.Id);

                    foreach (Domain.Habilidad_Especial HZ in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Domain.Clase_HE CHX = BusinessLogic.Clase_HEBL.Obtener(IdC, HZ.Id);
                        if (CHX != null)
                        {
                            HHH.Add(HZ);
                        }
                    }
                    listviewHdeC.ItemsSource = HHH;

                    List<Domain.Habilidad_Especial> Laux = new List<Domain.Habilidad_Especial>();
                    foreach (Domain.Habilidad_Especial Haux in BusinessLogic.HabilidadEspecialBL.Listar())
                    {
                        Domain.Clase_HE CA = BusinessLogic.Clase_HEBL.Obtener(IdC, Haux.Id);
                        if (CA == null)
                        {
                           Laux.Add(Haux);
                        }
                    }
                    listviewHSistema.ItemsSource = Laux;

                    if (aux == -1)
                    {
                        MessageBox.Show("A ocurrido un error inesperado al intentar eliminar la Habilidad de la Clase");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una Habilidad de la lista antes de precionar Eliminar");
                }
            }
        }

        private void listviewHSistema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domain.Habilidad_Especial Hu = (Domain.Habilidad_Especial)listviewHSistema.SelectedItem;
            if (Hu != null)
            {
                NombreH.Text = Hu.Nombre;
            }
            
        }

        private void listviewHdeC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domain.Habilidad_Especial H = (Domain.Habilidad_Especial)listviewHdeC.SelectedItem;
            if(H != null)
            {
                NombreH.Text = H.Nombre;
            }
        
        }
    }
}
