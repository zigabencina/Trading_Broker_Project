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
        private static readonly User[] Users = CsvToUser.GetUsers();
        /// 
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new First_page());





        }
        private static void login()
        {
            First_page f = new First_page();


            var username = f.getUsername();
            var password = f.getPass();

            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if(user != null)
            {
                // naredi
            }

        }
    }
}
