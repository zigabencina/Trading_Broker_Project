using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Broker_Project
{
    internal class AVConnection
    {
       
        private readonly string _apiKey;

        public AVConnection(string apiKey)
        {
            this._apiKey = apiKey; // pri klicu objekta vnesemo kot parameter api kljuc
        }

        public void SaveCSVFromURL(string symbol)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={this._apiKey}&datatype=csv"); // pošljemo request strani
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse(); //vrne nam csv datoteko z podatki

            StreamReader sr = new StreamReader(resp.GetResponseStream()); // uporabi streamreader iz knjižnice system.io da prebermo csv datoteko
            string results = sr.ReadToEnd(); // zapisemo v spremelnjivko kot string
            sr.Close();
            File.WriteAllText("stockdata.csv", results); // zapisemo v lokalno datoteko
        }


    }
}
