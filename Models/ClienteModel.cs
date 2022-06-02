using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Models
{
    internal class ClienteModel
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        
        public ClienteModel()
        {
            DNI = "1234";
            Nombre = "Ramiro";
            Direccion = "C/Mayor 13";
            Telefono = "687441230";
            Email = "r@gmail.com";
            
        }
    }
}
