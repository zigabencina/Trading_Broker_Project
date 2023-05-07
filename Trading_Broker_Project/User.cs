using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Broker_Project
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string Country { get; set; }
        public int Balance { get; set; }

        public void ChangePassword(string newPass)
        {
            Password = newPass;
        }

    }
}
