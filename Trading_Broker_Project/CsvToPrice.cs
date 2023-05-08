using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Broker_Project
{
    internal class CsvToPrice
    {
        private const string CsvPot = "stockdata.csv";

        
        public static Price[] GetPrice()
        {
            using (var reader = new StreamReader(CsvPot))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<Price>().ToArray();
                }
            }
        }
        public static void addToCSV()
        {
            AVConnection conn = new AVConnection("demo"); // definiramo objekt in damo v funkcijo api kljuc, ki smo ga dobili na spletni strani --> apikey = ZL4LHLXWTVKH4U4Q
            conn.SaveCSVFromURL("IBM");// povemo za kero valuto bi radi dobili podatke



        }
    }
}
