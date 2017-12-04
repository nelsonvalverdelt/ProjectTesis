using ProjectTesis.Service.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesis.Service.Models
{
    public class VentasCsv : ICsvFormat
    {
        public int Cliente_Key { get; set; }
        public int Empleado_Key { get; set; }
        public int Producto_Key { get; set; }
        public int Tiempo_Key { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal RecargoUsoTarjeta { get; set; }
        public decimal MontoTotal { get; set; }

        public string BuildCsvHeader()
        {
            string header = "Cliente_Key,Empleado_Key,Producto_Key,Tiempo_Key,Precio,Cantidad,Monto,RecargoUsoTarjeta,MontoTotal";
            return header;
        }

        public string BuildCsvItem()
        {
            string item = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}"
                           , CsvFormatItem.Escape(Cliente_Key)
                           , CsvFormatItem.Escape(Empleado_Key)
                           , CsvFormatItem.Escape(Producto_Key)
                           , CsvFormatItem.Escape(Tiempo_Key)
                           , CsvFormatItem.Escape(Precio)
                           , CsvFormatItem.Escape(Cantidad)
                           , CsvFormatItem.Escape(Monto)
                           , CsvFormatItem.Escape(RecargoUsoTarjeta)
                           , CsvFormatItem.Escape(MontoTotal));

            //PI.Net.Http.Formatting.CsvFormatter.Models.CsvFormatItem will take the value and call ToString() 
            //it will then clean the string for a CSV file removing line spaces etc
            return item;
        }
    }
}