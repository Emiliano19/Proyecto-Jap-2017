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

namespace GraphicInterface.Personaje
{
    /// <summary>
    /// Lógica de interacción para VerDetalles.xaml
    /// </summary>
    public partial class VerDetalles : Page
    {
        public VerDetalles(int value)
        {
            InitializeComponent();
            IdPersonaje.Text = value.ToString();
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<PersonajeCaracteristica> PC = new List<PersonajeCaracteristica>();
            foreach (Domain.Caracteristica C in BusinessLogic.CaracteristicaBL.Listar())
            {
                Domain.Personaje_Caracteristica aux = BusinessLogic.Personaje_CaracteristicaBL.Obtener(Convert.ToInt32(IdPersonaje.Text), C.Id);
                PersonajeCaracteristica Paux = new PersonajeCaracteristica();
                Paux.Nombre = C.Nombre;
                Paux.Valor = aux.valor;
                PC.Add(Paux);

            }
            listviewcar2.ItemsSource = PC;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Domain.Habilidad_Especial> PH = new List<Domain.Habilidad_Especial>();
            foreach (Domain.Habilidad_Especial H in BusinessLogic.HabilidadEspecialBL.Listar())
            {
                Domain.Personaje_HE aux = BusinessLogic.Personaje_HEBL.Obtener(Convert.ToInt32(IdPersonaje.Text), H.Id);
                if(aux != null)
                {
                    PH.Add(H);
                }
              
            }
            if(PH.Count != 0)
            {
                listviewcar2.ItemsSource = PH;
            }
            else
            {
                MessageBox.Show("Su Personaje no tiene Habilidades que mostrar");
            }

           
        }
    }
}
