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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            User user = new User();
            user.Name = namebox.Text;
            user.Surename = surenamebox.Text;
            user.AccountNumber = r.Next(1000000,9999999);
            user.IBAN = iban.Text;
            user.Username = username.Text;
            user.Password = password.Text;
            user.Country = country.Text;
            user.Balance = r.Next(100,1000001);
            CsvToUser.AddUser(user);

            MessageBox.Show("Nov uporabnik je bil ustvarjen!");

            this.Hide();
            this.Hide();
            
        }

        
    }
}
