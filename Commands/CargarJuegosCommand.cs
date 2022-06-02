using ProyectoJuegos.Services;
using ProyectoJuegos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class CargarJuegosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel juegosViewModel { get; set; }
        public FacturaViewModel FacturaViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            if (FacturaViewModel != null)
            {
                FacturaViewModel.ListaJuegos = await DBHandler.ObtenerJuegos("all");
            }
            else
            {
                juegosViewModel.ListaJuegos = await DBHandler.ObtenerJuegos("all");

            }
        }

        public CargarJuegosCommand(JuegosViewModel juegosViewModel)
        {
            this.juegosViewModel = juegosViewModel;
        }

        public CargarJuegosCommand(FacturaViewModel FacturaViewModel)
        {
            this.FacturaViewModel = FacturaViewModel;
        }


    }
}
