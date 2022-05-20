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

namespace ProyectoJuegos.Views
{
    /// <summary>
    /// Lógica de interacción para JuegosView.xaml
    /// </summary>
    public partial class JuegosView : UserControl
    {
        public JuegosView()
        {
            InitializeComponent();
            E00Inicial();
        }

        public void E00Inicial()
        {
            btnCancelar.Visibility = Visibility.Collapsed;
            btnModificar.Visibility = Visibility.Collapsed;
            btnCrear.Visibility = Visibility.Visible;
            btnAceptar.Visibility = Visibility.Collapsed;
            datosDialogo.IsEnabled = true;
            txCodigo.IsEnabled = true;
            juegosListView.IsEnabled = true;
        }

        public void E01MostarJuego()
        {
            btnCancelar.Visibility = Visibility.Visible;
            btnModificar.Visibility = Visibility.Visible;
            btnCrear.Visibility = Visibility.Collapsed;
            btnAceptar.Visibility = Visibility.Collapsed;
            datosDialogo.IsEnabled = false;
            txCodigo.IsEnabled = false;
            juegosListView.IsEnabled = true;


        }

        public void E02EditarJuego()
        {
            btnCancelar.Visibility = Visibility.Visible;
            btnModificar.Visibility = Visibility.Collapsed;
            btnCrear.Visibility = Visibility.Collapsed;
            btnAceptar.Visibility = Visibility.Visible;
            datosDialogo.IsEnabled = true;
            txCodigo.IsEnabled = false;
            juegosListView.IsEnabled = false;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            E02EditarJuego();
        }
    }
}
