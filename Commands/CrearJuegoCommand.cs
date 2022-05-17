using ProyectoJuegos.Services;
using ProyectoJuegos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    class CrearJuegoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        JuegosViewModel JuegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DBHandler.InsertarJuego(JuegosViewModel.Juego);
            //DBHandler.ObtenerJuegos("all");
        }

        public CrearJuegoCommand(JuegosViewModel JuegosViewModel)
        {
            this.JuegosViewModel = JuegosViewModel;
        }
    }
}
