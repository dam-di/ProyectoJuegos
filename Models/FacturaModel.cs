using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    internal class FacturaModel:INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<JuegoFacturaModel> listaJuegos { get; set; }
        public ObservableCollection<JuegoFacturaModel> ListaJuegos
        {
            get { return listaJuegos; }
            set { listaJuegos = value; OnPropertyChanged(nameof(listaJuegos)); }
        }
        public DateTime FechaFactura { get; set; }
        public ClienteModel Cliente { get; set; }
        public decimal Total { get; set; }

        public FacturaModel()
        {
            ListaJuegos = new ObservableCollection<JuegoFacturaModel>();
            Cliente = new ClienteModel();
            Total = 123;
            FechaFactura = DateTime.Now;
        }
    }
}
