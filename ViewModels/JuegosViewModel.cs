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
    class JuegosViewModel:ViewModelBase
    {
        public JuegoModel JuegoCurrent { get; set; }
        
        private ObservableCollection<ProveedorModel> listaProveedores { get; set; }
        public ObservableCollection<ProveedorModel> ListaProveedores
        {
            get
            {
                return listaProveedores;
            }
            set
            {
                listaProveedores = value;
                OnPropertyChanged(nameof(ListaProveedores));
            }

        }

        private ProveedorModel currentProveedor { get; set; }
        public ProveedorModel CurrentProveedor
        {
            get
            {
                return currentProveedor;
            }
            set
            {
                currentProveedor = value;
                OnPropertyChanged(nameof(CurrentProveedor));
            }
        }

       


        private JuegoModel juego { get; set; }
        public JuegoModel Juego { 
            get { 
                return juego; 
            }
            set
            {
                juego = value;
                OnPropertyChanged(nameof(Juego));
            }
        }
        public ICommand CrearJuegoCommand { get; set; }
        public ICommand CargarJuegosCommand { get; set; }
        public ICommand LoadJuegoCommand { get; set; }
        public ICommand CancelarCommand { get; set; }
        public ICommand ActualizarJuegoCommand { get; set; }
        public ICommand CargarProveedoresCommand { get; set; }
        public ICommand ModificarJuegoCommand { get; set; }
        public ICommand AddPToProductCommand { get; set; }
        private ObservableCollection<JuegoModel> listajuegos { get; set; }
        public ObservableCollection<JuegoModel> ListaJuegos 
        {
            get
            {
                return listajuegos;
            }
            set
            { 
                listajuegos = value;
                OnPropertyChanged(nameof(ListaJuegos));
            }
                
        }
        
        public JuegosViewModel()
        {
            ListaProveedores = new ObservableCollection<ProveedorModel>();
            Juego = new JuegoModel();
            JuegoCurrent = new JuegoModel();
            CrearJuegoCommand = new CrearJuegoCommand(this);
            ListaJuegos = new ObservableCollection<JuegoModel>();
            CargarJuegosCommand = new CargarJuegosCommand(this);
            LoadJuegoCommand = new LoadJuegoCommand(this);
            CancelarCommand = new CancelarCommand(this);
            ActualizarJuegoCommand = new ActualizarJuegoCommand(this);
            CargarProveedoresCommand = new CargarProveedoresCommand(this);
            ModificarJuegoCommand = new ModificarJuegoCommand(this);
            AddPToProductCommand = new AddPToProductCommand(this);

        }
    }
}
