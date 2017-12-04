using ProjectTesis.Service.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesis.Service.Models
{
    public class TiempoCsv: ICsvFormat
    {
        public int Tiempo_Key { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }

        public string BuildCsvHeader()
        {
            string header = "Tiempo_Key,Fecha,Año,Mes,Dia,Hora,Minuto";
            return header;
        }

        public string BuildCsvItem()
        {
            string item = String.Format("{0},{1},{2},{3},{4},{5},{6}"
                           , CsvFormatItem.Escape(Tiempo_Key)
                           , CsvFormatItem.Escape(Fecha)
                           , CsvFormatItem.Escape(Año)
                           , CsvFormatItem.Escape(Mes)
                           , CsvFormatItem.Escape(Dia)
                           , CsvFormatItem.Escape(Hora)
                           , CsvFormatItem.Escape(Minuto));

            //PI.Net.Http.Formatting.CsvFormatter.Models.CsvFormatItem will take the value and call ToString() 
            //it will then clean the string for a CSV file removing line spaces etc
            return item;
        }
    }
}