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
using BusinessLogic;
using System.Configuration;
using System.Data;

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Page
    {
        public Listar()
        {
            InitializeComponent();
            
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                ComboPer.ItemsSource = BusinessLogic.PersonajeBL.Listar();
                ComboPer.SelectedValuePath = "IdPer";
                ComboPer.DisplayMemberPath = "Nombre";
            }

            if(BusinessLogic.RazaBL.Listar() != null)
            {
                ComboRaza.ItemsSource = BusinessLogic.RazaBL.Listar();
                ComboRaza.SelectedValuePath = "IdRaza";
                ComboRaza.DisplayMemberPath = "Nombre";
            }
           
            if(BusinessLogic.ClaseBL.Listar() != null)
            {
                ComboClase.ItemsSource = BusinessLogic.ClaseBL.Listar();
                ComboClase.SelectedValuePath = "IdClase";
                ComboClase.DisplayMemberPath = "Nombre";
            }
          
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                List<PersonajeLista> PL2 = new List<PersonajeLista>();
                foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                {
                    PersonajeLista PLL = new PersonajeLista();
                    PLL.RazaNombre = P.RazaAtributo.Nombre;
                    PLL.ClaseNombre = P.ClaseAtributo.Nombre;
                    PLL.Nombre = P.Nombre;
                    PLL.Nivel = P.Nivel;
                    PLL.Fuerza = P.Fuerza;
                    PLL.Destreza = P.Destreza;
                    PLL.Constitucion = P.Constitucion;
                    PLL.Inteligencia = P.Inteligencia;
                    PLL.Sabiduria = P.Sabiduria;
                    PLL.Carisma = P.Carisma;
                    PLL.Imagen = P.Imagen;
                    PL2.Add(PLL);

                }
                listview.ItemsSource = PL2;
            }
            else
            {
                MessageBox.Show("No Hay Personajes para mostrar en el sistema debe crear algunos antes de listar");
            }

        }

        static string _ConnectionString = ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BotonRaza_Click(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboRaza.SelectedItem != null)
                {
                    Domain.Raza selectedItem = (Domain.Raza)ComboRaza.SelectedItem;
                    List<Domain.Personaje> PL = new List<Domain.Personaje>();
                    foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                    {
                        if (P.RazaAtributo.Id == selectedItem.Id)
                        {
                            PL.Add(P);
                        }
                    }
                    listview.ItemsSource = PL;
                }
                else
                {
                    MessageBox.Show("Debe elegir una Raza antes de precionar Filtrado por Raza");
                }
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede realizar el filtrado");
            }
          
        }

        private void BotonClase_Click(object sender, RoutedEventArgs e)
        {
            if (BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboClase.SelectedItem != null)
                {
                    Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
                    List<Domain.Personaje> PL = new List<Domain.Personaje>();
                    foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                    {
                        if (P.ClaseAtributo.Id == selectedItem.Id)
                        {
                            PL.Add(P);
                        }
                    }
                    listview.ItemsSource = PL;
                }
                else
                {
                    MessageBox.Show("Debe elegir una Clase antes de precionar Filtrado por Clase");
                }
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede realizar el filtrado");
            }
           
        }

        private void BotonDoble_Click(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboRaza.SelectedItem != null && ComboClase.SelectedItem != null)
                {
                    Domain.Raza selectedItemX = (Domain.Raza)ComboRaza.SelectedItem;
                    List<Domain.Personaje> PLX = new List<Domain.Personaje>();
                    foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                    {
                        if (P.RazaAtributo.Id == selectedItemX.Id)
                        {
                            PLX.Add(P);
                        }
                    }
                    Domain.Clase selectedItem = (Domain.Clase)ComboClase.SelectedItem;
                    List<Domain.Personaje> PL = new List<Domain.Personaje>();
                    foreach (Domain.Personaje P in PLX)
                    {
                        if (P.ClaseAtributo.Id == selectedItem.Id)
                        {
                            PL.Add(P);
                        }
                    }

                    listview.ItemsSource = PL;
                }
                else
                {
                    MessageBox.Show("Debe elegir una Raza y una Clase antes de precionar Filtrado doble");
                }
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede realizar el filtrado");
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboPer.SelectedItem != null)
                {
                    Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
                    this.Navigate1.Navigate(new VerDetalles(selectItem.Id));
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Personaje antes precionar Ver Detalles");
                }
             
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede Ver Detalles");
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Domain.Personaje selectItem = (Domain.Personaje)listview.SelectedItem;
           
        }

        private void Seleccionar_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboPer.SelectedItem != null)
                {
                    listview.Visibility = Visibility.Collapsed;
                    Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
                    this.Navigate1.Navigate(new Modificar(selectItem.Id));
                }
                else if (ComboPer.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un Personaje del combobox antes de precionar Modificar");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Personaje de la lista antes de precionar Modificar");
            }
           
    
        }

        private void ComboPer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboPer.SelectedItem != null)
                {
                    Domain.Personaje selectItem = (Domain.Personaje)ComboPer.SelectedItem;
                    int result = BusinessLogic.PersonajeBL.Eliminar(selectItem.Id);
                    if (result == 1)
                    {
                        if(BusinessLogic.PersonajeBL.Listar() != null)
                        {
                            List<Domain.Personaje> PP = new List<Domain.Personaje>();
                            foreach (Domain.Personaje P in BusinessLogic.PersonajeBL.Listar())
                            {
                                if (P.Id != selectItem.Id)
                                {
                                    PP.Add(P);
                                }

                            }
                            listview.ItemsSource = PP;
                        }
                        else
                        {
                            ComboPer.ItemsSource = null;
                            listview.ItemsSource = null;
                        }
                        MessageBox.Show("Se a borrado el Personaje con Exito");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("A ocurrido algún error y no se a podido borrar el Personaje seleccionado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Personaje de la lista antes de precionar Eliminar");
                }
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede Eliminar");
            }
           
        }

        private void Navigate_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Regresar_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPrincipal());
        }

        private void SubirNivel_Click(object sender, RoutedEventArgs e)
        {
            if(BusinessLogic.PersonajeBL.Listar() != null)
            {
                if (ComboPer.SelectedItem != null)
                {
                    Domain.Personaje P = (Domain.Personaje)ComboPer.SelectedItem;
                    if(P.Nivel <= 10)
                    {
                        int NivelAnterior;
                        int IdR = P.RazaAtributo.Id;
                        int IdC = P.ClaseAtributo.Id;
                        NivelAnterior = P.Nivel;
                        P.Nivel = P.Nivel + 1;
                        BusinessLogic.PersonajeBL.Modificar(P, IdR, IdC);

                        if (BusinessLogic.HabilidadEspecialBL.Listar() != null)
                        {
                            List<Domain.Habilidad_Especial> Hll = new List<Domain.Habilidad_Especial>();
                            foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
                            {
                                Domain.Clase_HE HC = BusinessLogic.Clase_HEBL.Obtener(IdC, H.Id);

                                if (HC != null)
                                {
                                    Hll.Add(H);
                                }
                            }
                            bool contHP = true;
                            int contHPP = 0;
                            foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
                            {
                                Domain.Personaje_HE HP = BusinessLogic.Personaje_HEBL.Obtener(P.Id, H.Id);

                                if (HP != null)
                                {
                                    contHPP = contHPP + 1;
                                }
                            }
                            if(Hll.Count != contHPP)
                            {
                                contHP = false;
                            }
                            int aux = NivelAnterior % 2;
                            bool Par = true;
                            if (aux != 0)
                            {
                                Par = false;
                            }
                            if (contHP == true && Par == true)
                            {
                                MessageBox.Show("El Nivel a subido pero no hay Habilidades extras para asignarle al Personaje y al ser par su Nivel tampoco aumenta valor de las Características");
                            }
                            else
                            {
                                this.NavigationService.Navigate(new Subir_de_Nivel(P.Id, NivelAnterior));
                            }
                        }

                        if (BusinessLogic.PersonajeBL.Listar() != null)
                        {
                            List<PersonajeLista> PL2 = new List<PersonajeLista>();
                            foreach (Domain.Personaje Px in BusinessLogic.PersonajeBL.Listar())
                            {
                                PersonajeLista PLL = new PersonajeLista();
                                PLL.RazaNombre = Px.RazaAtributo.Nombre;
                                PLL.ClaseNombre = Px.ClaseAtributo.Nombre;
                                PLL.Nombre = Px.Nombre;
                                PLL.Nivel = Px.Nivel;
                                PLL.Fuerza = Px.Fuerza;
                                PLL.Destreza = Px.Destreza;
                                PLL.Constitucion = Px.Constitucion;
                                PLL.Inteligencia = Px.Inteligencia;
                                PLL.Sabiduria = Px.Sabiduria;
                                PLL.Carisma = Px.Carisma;
                                PLL.Imagen = Px.Imagen;
                                PL2.Add(PLL);

                            }
                            listview.ItemsSource = PL2;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Nivel de este Personaje ya esta en el Máximo permitido por lo que no puede volver a incrementarlo");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un personaje del ComboBox antes de precionar Subir de Nivel");
                }
            }
            else
            {
                MessageBox.Show("No hay personajes en el sistema así que no se puede Subir de Nivel");
            }
           
           
        }
    }                
}
