using ProyectoJuegos.Models;
using ProyectoJuegos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class AddJuegoFacturaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FacturaViewModel FacturaViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            bool noEncontrado = true;
            foreach(JuegoFacturaModel juegoFactura in FacturaViewModel.Factura.ListaJuegos)
            {
                if (juegoFactura.JuegoModel._id.Equals(FacturaViewModel.SelectedJuego._id)){
                    noEncontrado = false;
                    juegoFactura.Cantidad = juegoFactura.Cantidad + FacturaViewModel.Cantidad;
                }
            }

            if (noEncontrado)
            {
                JuegoFacturaModel jf = new JuegoFacturaModel();
                jf.JuegoModel = FacturaViewModel.SelectedJuego;
                jf.Cantidad = FacturaViewModel.Cantidad;

                FacturaViewModel.Factura.ListaJuegos.Add(jf);
                
            }

            FacturaViewModel.Cantidad = 1;
            //FacturaViewModel.SelectedJuego = new JuegoModel();




        }

        public AddJuegoFacturaCommand(FacturaViewModel FacturaViewModel)
        {
            this.FacturaViewModel = FacturaViewModel;
        }
    }
}
