using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Broker_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        /// 
        


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new First_page());


            


        }
        public static readonly User[] Users = CsvToUser.GetUsers();
        public static User curruser;
        public static bool Login(string username,string password)
        {
            First_page f = new First_page();

            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password); // lamba funkcija u postane user ce je username in password isti kot uporabnikov
            // unnecessary if :)
            curruser = user;
            if (user != null)
            {
                

                return true;
            }
            else {
                MessageBox.Show("FoRGoR? 💀");

                return false;
            }
        }
    }
}
