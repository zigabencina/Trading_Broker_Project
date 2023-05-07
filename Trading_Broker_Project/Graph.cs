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
        public static void addToGraph()
        {
            AVConnection conn = new AVConnection("demo"); // definiramo objekt in damo v funkcijo api kljuc, ki smo ga dobili na spletni strani --> apikey = ZL4LHLXWTVKH4U4Q
            conn.SaveCSVFromURL("IBM");// povemo za kero valuto bi radi dobili podatke

            
            string coloumn1;
            string coloumn2;
            var path = "stockdata.csv";
            using (TextFieldParser csvReader = new TextFieldParser(path))
            {
                csvReader.CommentTokens = new string[] { "#" };
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvReader.ReadLine();

                while (!csvReader.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvReader.ReadFields();
                    coloumn1 = fields[0];
                    coloumn2 = fields[1];
                }

            }
        }
    }
}
