using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    public class JuegoModel
    {
        public int _id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }
        public string Nombre { get; set; }    
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
        public string Materiales { get; set; }
        public ObservableCollection<string> Proveedores { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        
        public JuegoModel()
        {
            Proveedores = new ObservableCollection<string>();
        }
    }
}
