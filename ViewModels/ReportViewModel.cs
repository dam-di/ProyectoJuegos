using Microsoft.Reporting.WinForms;
using ProyectoJuegos.Services.DataSet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.ViewModels
{
    internal class ReportViewModel:ViewModelBase
    {
        public string pdfData { get; set; }
        ReportViewer myReport { get; set; }
        ReportDataSource rds { get; set; }

        public ReportViewModel()
        {
            rds = new ReportDataSource();
            myReport = new ReportViewer();
        }

        public bool GenerarFacturaByDNI(string dni)
        {
            rds.Name = "FacturaCliente";
            DataTable dt = DataSetHandler.GetDataByDNI(dni);
            if(dt.Rows.Count > 0)
            {
                rds.Value = dt;
                myReport.LocalReport.DataSources.Add(rds);
                myReport.LocalReport.ReportPath = "../../../Reports/FacturaDNI.rdlc";
                byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
                pdfData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
