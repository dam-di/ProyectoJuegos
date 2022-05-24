using ProyectoJuegos.Models;
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

        public async void Execute(object parameter)
        {
            
            bool okinsertar = await DBHandler.InsertarJuego(JuegosViewModel.Juego);
            if (okinsertar)
            {
                MessageBox.Show("Juego insertado con éxito");
                JuegosViewModel.Juego = new JuegoModel();
                JuegosViewModel.CargarJuegosCommand.Execute("");
            }
            //DBHandler.ObtenerJuegos("all");
        }

        public CrearJuegoCommand(JuegosViewModel JuegosViewModel)
        {
            this.JuegosViewModel = JuegosViewModel;
        }
    }
}
