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
    

    public partial class Reset_password : Form
    {
        
        public Reset_password()
        {
            InitializeComponent();
            newpass.PasswordChar = '*';
            newpassconf.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void conformation_Click(object sender, EventArgs e)
        {
            if(newpass.Text != newpassconf.Text)
            {
                MessageBox.Show("Gesli se ne ujemata!");
                newpassconf.Clear();
                
            }
            else
            {
                var currentUser = Program.Users.FirstOrDefault(u => u.Username == username.Text);//najde userja s pomocjo funkcije in lambde
                
                currentUser.ChangePassword(newpassconf.Text);// spremeni geslo
                
            }
        }
    }
}
