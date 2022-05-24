using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    public class JuegoModel:ICloneable
    {
        public int _id { get; set; }
        public string Nombre { get; set; }    
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
        public string Materiales { get; set; }
        public ObservableCollection<ProveedorModel> Proveedores { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        
        public JuegoModel()
        {
            Proveedores = new ObservableCollection<ProveedorModel>();
            FechaLanzamiento = DateTime.Now;
            Color = "Rojo";
            Materiales = "Metal";

        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
