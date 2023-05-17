using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trading_Broker_Project
{
    public partial class First_page : Form
    {
        public First_page()
        {
            InitializeComponent();
            password.PasswordChar = '*';

        }

        private void usr_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void frogor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_password r = new Reset_password();

            r.ShowDialog();
            this.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //login class / form
            if (Program.Login(username.Text, password.Text))
            {
                this.Hide();
                main m = new main();

                m.ShowDialog();
                this.Show();
            }
            
               
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            //register class / form
            this.Hide();
            Evaluation r = new Evaluation();
            r.ShowDialog();
            this.Show();
        }
        public string getUsername()
        {
            return username.Text;
        }
        public string getPass()
        {
            return password.Text;
        }
        public void clear()
        {
            password.Text = string.Empty;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simulate a button click
                login.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }
    }
}
