using ProyectoJuegos.Models;
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
    internal class CancelarCommand : ICommand
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
                JuegosView view = (JuegosView)parameter;
                view.E00Inicial();
                JuegosViewModel.Juego = new JuegoModel();
                JuegosViewModel.CargarProveedoresCommand.Execute("");
            }
        }

        public CancelarCommand(JuegosViewModel juegosViewModel)
        {
            JuegosViewModel = juegosViewModel;
        }
    }
}
