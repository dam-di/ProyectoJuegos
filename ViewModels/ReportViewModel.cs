using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.ViewModels
{
    internal class ReportViewModel:ViewModelBase
    {
        public string pdfDarta { get; set; }
        ReportViewer myReport { get; set; }
        ReportDataSource rds { get; set; }

        public ReportViewModel()
        {
            rds = new ReportDataSource();
            myReport = new ReportViewer();
        }
    }
}
