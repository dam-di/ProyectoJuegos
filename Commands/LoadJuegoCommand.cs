using ProyectoJuegos.ViewModels;
using ProyectoJuegos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class LoadJuegoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel JuegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is JuegosView)
            {
                JuegosView vista = (JuegosView)parameter;
                JuegosViewModel.Juego = (Models.JuegoModel)JuegosViewModel.JuegoCurrent.Clone();
                
                vista.E01MostarJuego();
            }
            
        }

        public LoadJuegoCommand(JuegosViewModel juegosViewModel)
        {
            JuegosViewModel = juegosViewModel;
        }
    }
}
