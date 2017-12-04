using ProjectTesis.Service.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjectTesis.Service.Controllers
{
    public class OrbitumController : ApiController
    {
        AzureOrbitumMartConnection db = new AzureOrbitumMartConnection();

        [Route("api/Clientes")]
        public IHttpActionResult GetClientes()
        {
            List<ClienteCsv> listaClientes = new List<ClienteCsv>();

            foreach (var item in db.Dim_Cliente)
            {
                listaClientes.Add(new ClienteCsv
                {
                    Cliente_Key = item.Cliente_Key,
                    ClienteId = item.ClienteId,
                    Documento = item.Documento,
                    Nombre = item.Nombre
                });
            }
            return Ok(listaClientes);
        }
  
        [Route("api/Empleados")]
        public IHttpActionResult GetEmpleados()
        {
            List<EmpleadoCsv> listaEmpleados = new List<EmpleadoCsv>();
            foreach (var item in db.Dim_Empleado)
            {
                listaEmpleados.Add(new EmpleadoCsv
                {
                    Empleado_Key = item.Empleado_Key,
                    EmpleadoId = item.EmpleadoId,
                    Usuario = item.Usuario,
                    Nombre = item.Nombre
                });
            }

            return Ok(listaEmpleados);
        }
        [Route("api/Productos")]
        public IHttpActionResult GetProductos()
        {
            List<ProductoCsv> listaProductos = new List<ProductoCsv>();
            foreach (var item in db.Dim_Producto)
            {
                listaProductos.Add(new ProductoCsv
                {
                    Producto_Key = item.Producto_Key,
                    ProductoId = item.ProductoId,
                    Codigo = item.Codigo,
                    Nombre = item.Nombre,
                    Marca = item.Marca,
                    Grupo = item.Grupo,
                    SubGrupo = item.SubGrupo
                });
            }
 
            return Ok(listaProductos);
        }
        [Route("api/Tiempos")]
        public IHttpActionResult GetTiempos()
        {
            List<TiempoCsv> listaTiempos = new List<TiempoCsv>();
            foreach (var item in db.Dim_Tiempo)
            {
                listaTiempos.Add(new TiempoCsv
                {
                    Tiempo_Key = item.Tiempo_Key,
                    Fecha = item.Fecha,
                    Año = item.Año,
                    Mes = item.Mes,
                    Dia = item.Dia,
                    Hora = item.Hora,
                    Minuto = item.Minuto
                });
            }
            return Ok(listaTiempos);
        }
        [Route("api/Ventas")]
        public IHttpActionResult GetVentas()
        {
            List<VentasCsv> listaVentas = new List<VentasCsv>();
            foreach (var item in db.Fac_Ventas)
            {
                listaVentas.Add(new VentasCsv
                {
                    Cliente_Key = item.Cliente_Key,
                    Empleado_Key = item.Empleado_Key,
                    Producto_Key = item.Producto_Key,
                    Tiempo_Key = item.Tiempo_Key,
                    Precio = item.Precio,
                    Cantidad = item.Cantidad,
                    Monto = item.Monto,
                    RecargoUsoTarjeta = item.RecargoUsoTarjeta,
                    MontoTotal = item.MontoTotal

                });
            }

            return Ok(listaVentas);
        }
     
    }

}
