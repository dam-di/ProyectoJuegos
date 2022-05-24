using MaterialDesignThemes.Wpf;
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
    internal class AddPToProductCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public JuegosViewModel juegosViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is DialogHost)
            {
                bool existe = false;
                DialogHost dialogo = (DialogHost)parameter;

                
                foreach (ProveedorModel p in juegosViewModel.Juego.Proveedores)
                {
                    if (p._id.Equals(juegosViewModel.CurrentProveedor._id))
                    {
                        existe = true;
                        break;
                    }
                        
                }

                

                if (!existe)
                {
                    juegosViewModel.Juego.Proveedores.Add(juegosViewModel.CurrentProveedor);
                    dialogo.IsOpen = false;
                }
                else
                {
                    DialgoView d = new DialgoView("Ya has añadido este proveedor",
                                MessageType.Info, MessageButtons.Ok);
                    d.ShowDialog();
                }

                
                
                     
                
                
            }
            
        }

        public AddPToProductCommand(JuegosViewModel juegosViewModel)
        {
            this.juegosViewModel = juegosViewModel;
        }
    }
}
