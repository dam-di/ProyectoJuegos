using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    internal class JuegoFacturaModel:INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public JuegoModel JuegoModel { get; set; }
        private int cantidad { get; set; }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; OnPropertyChanged(nameof(Cantidad)); }
        }
        
        public JuegoFacturaModel()
        {
            JuegoModel = new JuegoModel();
        }

        
    }
}
