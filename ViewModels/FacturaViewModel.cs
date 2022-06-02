using ProyectoJuegos.Commands;
using ProyectoJuegos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.ViewModels
{
    internal class FacturaViewModel:ViewModelBase
    {
        private ObservableCollection<ClienteModel> listaClientes { set; get; }
        public ObservableCollection<ClienteModel> ListaClientes
        {
            get { 
                return listaClientes;
            }
            set
            {
                listaClientes = value;
                OnPropertyChanged(nameof(ListaClientes));
            }
        }

        private ObservableCollection<JuegoModel> listaJuegos { set; get; }
        public ObservableCollection<JuegoModel> ListaJuegos
        {
            get
            {
                return listaJuegos;
            }
            set
            {
                listaJuegos = value;
                OnPropertyChanged(nameof(ListaJuegos));
            }
        }
        public int cantidad { get; set; }
        public int Cantidad
        {
            set { cantidad = value; OnPropertyChanged(nameof(Cantidad)); }
            get { return cantidad; }
        }
        public ICommand CrearFacturaCommand { get; set; }
        public ICommand CargarJuegosCommand { get; set; }
        public ICommand AddJuegoFacturaCommand { get; set; }
        private JuegoModel selectedJuego { get; set; }
        public JuegoModel SelectedJuego
        {
            set { selectedJuego = value; OnPropertyChanged(nameof(SelectedJuego)); }
            get { return selectedJuego; }
        }
        //public DateTime Fecha { get; set; }
        public FacturaModel Factura { get; set; }

        

        public FacturaViewModel()
        {
            ListaClientes = new ObservableCollection<ClienteModel>();
            Factura = new FacturaModel();
            SelectedJuego = new JuegoModel();
            Cantidad = 1;
            CrearFacturaCommand = new CrearFacturaCommand(this);
            AddJuegoFacturaCommand = new AddJuegoFacturaCommand(this);
            CargarJuegosCommand = new CargarJuegosCommand(this);
        }
    }
}
