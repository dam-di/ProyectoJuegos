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
    internal class ConsultasCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ReportViewModel ReportViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //DataSetHandler.GetDataByDNI();
        }

        public ConsultasCommand(ReportViewModel reportViewModel)
        {
            ReportViewModel = reportViewModel;
        }
    }
}
