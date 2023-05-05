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
    public partial class First_page : Form
    {
        public First_page()
        {
            InitializeComponent();
            
            
        }

        private void usr_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frogor_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            //login class / form
            main m = new main();
            this.Close();
            m.Show();
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            //register class / form
        }
    }
}
