using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trading_Broker_Project
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();



        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void Graph_Load(object sender, EventArgs e)
        {
            Price[] prices = CsvToPrice.GetPrice();
            fillChart(prices);

        }
        private void fillChart(Price[] prices)
        {
            
            

            graph_price.Series["Daily"].XValueMember = "Day";
            graph_price.Series["Daily"].YValueMembers = "High,Low,Open,Close";
            graph_price.Series["Daily"]["ShowOpenClose"] = "both";
            graph_price.Series["Daily"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            graph_price.Series["Daily"]["OpenCloseStyle"] = "Triangle";
            graph_price.Series["Daily"]["PriceUpColor"] = "Green";
            graph_price.Series["Daily"]["PriceDownColor"] = "Red";

            /*
            for (int i = 0; i < prices.Length; i++)
            {
                graph_price.Series["Daily"].Points.AddXY(prices[i].timestamp, prices[i].close); // nafila chart
            }

            // adding date and high
            chart1.Series["price"].Points.AddXY(DateTime.Parse(k[i].Datum), k[i].Hoog);
            // adding low
            chart1.Series["price"].Points[i].YValues[1] = k[i].Laag;
            //adding open
            chart1.Series["price"].Points[i].YValues[2] = k[i].PrijsOpen;
            // adding close
            chart1.Series["price"].Points[i].YValues[3] = k[i].PrijsGesloten;


            */

            for (int i = 0; i < prices.Length; i++)
            {
                //graph_price.Series["Daily"].Points.AddXY(prices[i].timestamp,prices[i].open, prices[i].close, prices[i].high, prices[i].low);

                graph_price.Series["Daily"].Points.AddXY(DateTime.Parse(prices[i].timestamp), prices[i].high);
                // adding low
                graph_price.Series["Daily"].Points[i].YValues[1] = prices[i].low;
                //adding open
                graph_price.Series["Daily"].Points[i].YValues[2] = prices[i].open;
                // adding close
                graph_price.Series["Daily"].Points[i].YValues[3] = prices[i].close;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


