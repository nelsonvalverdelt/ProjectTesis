using ProjectTesis.Service.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesis.Service.Models
{
    public class ClienteCsv : ICsvFormat
    {
        public int Cliente_Key { get; set; }
        public int ClienteId { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }

        public string BuildCsvHeader()
        {
            string header = "Cliente_Key,ClienteId,Documento,Nombre";
            return header;
        }

        public string BuildCsvItem()
        {
            string item = String.Format("{0},{1},{2},{3}"
                           , CsvFormatItem.Escape(Cliente_Key)
                           , CsvFormatItem.Escape(ClienteId)
                           , CsvFormatItem.Escape(Documento)
                           , CsvFormatItem.Escape(Nombre));

            //PI.Net.Http.Formatting.CsvFormatter.Models.CsvFormatItem will take the value and call ToString() 
            //it will then clean the string for a CSV file removing line spaces etc
            return item;
        }
    }
}