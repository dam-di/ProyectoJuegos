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
    internal class CargarProveedoresCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel juegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            juegosViewModel.ListaProveedores = await DBHandler.ObtenerProveedores("all");
        }

        public CargarProveedoresCommand(JuegosViewModel juegosViewModel)
        {
            this.juegosViewModel = juegosViewModel;
        }
    }
}
