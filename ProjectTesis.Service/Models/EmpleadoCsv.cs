using ProjectTesis.Service.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesis.Service.Models
{
    public class EmpleadoCsv : ICsvFormat
    {
        public int Empleado_Key { get; set; }
        public int EmpleadoId { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }

        public string BuildCsvHeader()
        {

                string header = "Empleado_Key,EmpleadoId,Usuario,Nombre";
                return header;

        }

        public string BuildCsvItem()
        {
            string item = String.Format("{0},{1},{2},{3}"
                           , CsvFormatItem.Escape(Empleado_Key)
                           , CsvFormatItem.Escape(EmpleadoId)
                           , CsvFormatItem.Escape(Usuario)
                           , CsvFormatItem.Escape(Nombre));

            //PI.Net.Http.Formatting.CsvFormatter.Models.CsvFormatItem will take the value and call ToString() 
            //it will then clean the string for a CSV file removing line spaces etc
            return item;
        }
    }
}