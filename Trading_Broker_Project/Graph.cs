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
            for (int i = 0; i < prices.Length; i++)
            {
                graph_price.Series["price"].Points.AddXY(prices[i].timestamp, prices[i].close); // nafila chart
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


