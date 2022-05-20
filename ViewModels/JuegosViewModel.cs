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
                OnPropertyChanged(nameof(listajuegos));
            }
                
            }
        
        public JuegosViewModel()
        {
            Juego = new JuegoModel();
            JuegoCurrent = new JuegoModel();
            CrearJuegoCommand = new CrearJuegoCommand(this);
            ListaJuegos = new ObservableCollection<JuegoModel>();
            CargarJuegosCommand = new CargarJuegosCommand(this);
            LoadJuegoCommand = new LoadJuegoCommand(this);
            CancelarCommand = new CancelarCommand(this);
            ActualizarJuegoCommand = new ActualizarJuegoCommand(this);
        }
    }
}
