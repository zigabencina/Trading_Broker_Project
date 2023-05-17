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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void accbal_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            accbal.Text = Program.curruser.Balance + "";
            labelGreet.Text = "Pozdravljen " + Program.curruser.Name + "!";
        }

        private void graph_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph g = new Graph();

            g.ShowDialog();
            this.Show();
        }

        private void k_Click(object sender, EventArgs e)
        {

        }
    }
}
