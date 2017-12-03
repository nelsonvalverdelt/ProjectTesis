using ProjectTesis.Service.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjectTesis.Service.Controllers
{
    public class OrbitumController : ApiController
    {
        OrbitumMartConnection db = new OrbitumMartConnection();

        [Route("api/Clientes")]
        [HttpGet]
        public IEnumerable<Dim_Cliente> GetCliente()
        {
            return db.Dim_Cliente;
        }
        [Route("api/Empleados")]
        [HttpGet]
        public IEnumerable<Dim_Empleado> GetEmpleado()
        {
            return db.Dim_Empleado;
        }
        [Route("api/Productos")]
        [HttpGet]
        public IEnumerable<Dim_Producto> GetProducto()
        {
            return db.Dim_Producto;
        }
        [Route("api/Tiempos")]
        [HttpGet]
        public IEnumerable<Dim_Tiempo> GetTiempo()
        {
            return db.Dim_Tiempo;
        }
        [Route("api/Ventas")]
        [HttpGet]
        public IEnumerable<Fac_Ventas> GetVentas()
        {
            return db.Fac_Ventas;
        }
            
    }

}
