using Newtonsoft.Json;
using ProyectoJuegos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoJuegos.Services
{
    internal class DBHandler
    {
        public static async Task<bool> InsertarJuego(JuegoModel Juego)
        {
            
            RequestModel requestModel = new RequestModel();
            requestModel.method = "POST";
            requestModel.route = "/juegos";
            requestModel.data = Juego;
            ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);
            
            return await Task.FromResult(responseModel.resultOk);
        }

        public static async Task<bool> ModificarJuego(JuegoModel Juego)
        {

            RequestModel requestModel = new RequestModel();
            requestModel.method = "PUT";
            requestModel.route = "/juegos";
            requestModel.data = Juego;
            ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);

            return await Task.FromResult(responseModel.resultOk);
        }


        public static async Task<ResponseModel> EliminarJuego(JuegoModel Juego)
        {

            RequestModel requestModel = new RequestModel();
            requestModel.method = "DELETE";
            requestModel.route = "/juegos";
            requestModel.data = Juego._id;
            ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);

            return await Task.FromResult(responseModel);
        }



        public static async Task<ObservableCollection<JuegoModel>> ObtenerJuegos(string _idJ)
        {
            ObservableCollection<JuegoModel> listaJuegos = new ObservableCollection<JuegoModel>();
            RequestModel requestModel = new RequestModel();
            requestModel.method = "GET";
            requestModel.route = "/juegos";
            requestModel.data = _idJ;
            ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);
            Console.WriteLine(responseModel.data);
            Console.WriteLine(responseModel.resultOk);
            if (responseModel.resultOk)
            {
                
                listaJuegos = JsonConvert.DeserializeObject<ObservableCollection<JuegoModel>>((string)responseModel.data);
                //MessageBox.Show("CONSULTA OK");
            }
            else
            {
                
            }
            return await Task.FromResult(listaJuegos);
        }



        public static async Task<ObservableCollection<ProveedorModel>> ObtenerProveedores(string _idP)
        {
            ObservableCollection<ProveedorModel> listaProveedores = new ObservableCollection<ProveedorModel>();
            RequestModel requestModel = new RequestModel();
            requestModel.method = "GET";
            requestModel.route = "/proveedores";
            requestModel.data = _idP;
            ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);
            if (responseModel.resultOk)
            {
                listaProveedores = JsonConvert.DeserializeObject<ObservableCollection<ProveedorModel>>((string)responseModel.data);
                //MessageBox.Show("CONSULTA OK");
            }
            else
            {

            }
            return await Task.FromResult(listaProveedores);
        }
    }
}
