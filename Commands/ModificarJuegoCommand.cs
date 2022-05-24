using ProyectoJuegos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class ModificarJuegoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel juegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //juegosViewModel.ListaProveedores = juegosViewModel.Juego.Proveedores;
        }

        public ModificarJuegoCommand(JuegosViewModel juegosViewModel)
        {
            this.juegosViewModel = juegosViewModel;
        }
    }
}
