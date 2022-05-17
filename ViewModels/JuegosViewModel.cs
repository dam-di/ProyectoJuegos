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
        public JuegoModel Juego { get; set; }
        public ICommand CrearJuegoCommand { get; set; }
        public ICommand CargarJuegosCommand { get; set; }

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
            CrearJuegoCommand = new CrearJuegoCommand(this);
            ListaJuegos = new ObservableCollection<JuegoModel>();
            CargarJuegosCommand = new CargarJuegosCommand(this);
        }
    }
}
