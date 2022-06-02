using ProyectoJuegos.Models;
using ProyectoJuegos.Services.DataSet;
using ProyectoJuegos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoJuegos.Commands
{
    internal class CrearFacturaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public FacturaViewModel FacturaViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            /*
            FacturaModel f = new FacturaModel();
            f.FechaFactura = DateTime.Now;
            f.Total = 123;
            f.Cliente = new ClienteModel()
            {
                Direccion = "fdsf",
                DNI = "321",
                Email = "dfsfds",
                Nombre = "dffs",
                Telefono = "312"
            };
            JuegoModel juego = new JuegoModel()
            {
                Nombre="21312",
                Color=
            };
            f.ListaJuegos.Add()
            */

            DataSetHandler.CrearFactura(FacturaViewModel.Factura);
        }

        public CrearFacturaCommand(FacturaViewModel facturaViewModel)
        {
            FacturaViewModel = facturaViewModel;
        }
    }
}
