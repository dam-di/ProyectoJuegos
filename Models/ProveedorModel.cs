using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    public class ProveedorModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id;
        public string _id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(nameof(id)); }
        }
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; OnPropertyChanged(nameof(Nombre)); } }


        private string direccion;
        public string Direccion { get { return direccion; } set { direccion = value; OnPropertyChanged(nameof(Direccion)); } }

        private string correo;
        public string Correo { get { return correo; } set { correo = value; OnPropertyChanged(nameof(Correo)); } }

        private string poblacion;
        public string Poblacion { get { return poblacion; } set { poblacion = value; OnPropertyChanged(nameof(Poblacion)); } }
        private int telefono;
        public int Tlefono { get { return telefono; } set { telefono = value; OnPropertyChanged(nameof(telefono)); } }

        public ProveedorModel()
        {

        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}

