using ProyectoJuegos.Services;
using ProyectoJuegos.ViewModels;
using ProyectoJuegos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class ActualizarJuegoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel JuegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            if(parameter is JuegosView)
            {
                JuegosView vista = (JuegosView)parameter;
                bool okInsertar = await DBHandler.ModificarJuego(JuegosViewModel.Juego);
                if (okInsertar)
                {
                    MessageBox.Show("Juego actualizado correctamente");
                    JuegosViewModel.CargarJuegosCommand.Execute("");
                    vista.E00Inicial();
                    JuegosViewModel.Juego = new Models.JuegoModel();
                    
                }
                
            }
        }

        public ActualizarJuegoCommand(JuegosViewModel juegosViewModel)
        {
            JuegosViewModel = juegosViewModel;
        }
    }
}
