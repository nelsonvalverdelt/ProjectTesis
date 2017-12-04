using ProjectTesis.Service.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesis.Service.Models
{
    public class ProductoCsv: ICsvFormat
    {

        public int Producto_Key { get; set; }
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Grupo { get; set; }
        public string SubGrupo { get; set; }

        public string BuildCsvHeader()
        {
            string header = "Producto_Key,ProductoId,Codigo,Nombre,Marca,Grupo,SubGrupo";
            return header;
        }

        public string BuildCsvItem()
        {
            string item = String.Format("{0},{1},{2},{3},{4},{5},{6}"
                           , CsvFormatItem.Escape(Producto_Key)
                           , CsvFormatItem.Escape(ProductoId)
                           , CsvFormatItem.Escape(Codigo)
                           , CsvFormatItem.Escape(Nombre)
                           , CsvFormatItem.Escape(Marca)
                           , CsvFormatItem.Escape(Grupo)
                           , CsvFormatItem.Escape(SubGrupo));

            //PI.Net.Http.Formatting.CsvFormatter.Models.CsvFormatItem will take the value and call ToString() 
            //it will then clean the string for a CSV file removing line spaces etc
            return item;
        }
    }
}