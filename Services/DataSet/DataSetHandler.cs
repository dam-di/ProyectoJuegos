using ProyectoJuegos.Models;
using ProyectoJuegos.Services.DataSet._2damXXDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJuegos.Services.DataSet
{
    internal class DataSetHandler
    {
        private static facturaTableAdapter facturaAdapter = new facturaTableAdapter();
        private static detalleTableAdapter detalleAdapter = new detalleTableAdapter();

        private static InformeTableAdapter adapter = new InformeTableAdapter();

        public static void CrearFactura(FacturaModel Factura)
        {
            /*
             * idCliente
             * Fecha factura
             * Total
             * 
             * Detalle
             * Id factura (La obenemos de insertar en la tabla factura)
             * 
             * LISTA DE PRODUCTOS
             * id producto
             * Cantidad
             * Precio
             * Descripcion
             */

            //PRIMERO INSERTARMOS EN LA TABLA FACTURA
            facturaAdapter.Insert(Factura.Cliente.DNI, Factura.FechaFactura, Factura.Total);

            //OBTENER LA ID DE LA ÚLTIMA FACTURA
            DataRow ultimoFactura = facturaAdapter.GetData().Last();
            int idUltimaFactura = (int)ultimoFactura["idFactura"];

            foreach(var producto in Factura.ListaJuegos)
            {
                detalleAdapter.Insert(idUltimaFactura, producto.JuegoModel._id.ToString(), 
                    producto.Cantidad, producto.JuegoModel.Precio, 
                    producto.JuegoModel.Descripcion);
            }

            
        }

        public static DataTable GetDataByDNI(string dni)
        {
            return adapter.GetDataByDNI(dni);
        }

    }
}
