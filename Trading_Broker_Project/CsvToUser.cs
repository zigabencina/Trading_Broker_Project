using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace Trading_Broker_Project
{
    class CsvToUser
    {
        private const string CsvPot = "C:\\Users\\zigab\\OneDrive\\Documents\\Trading_Broker_Project\\Trading_Broker_Project\\users.csv";

        public static void AddUser(User user)
        {
            using (var writer = new StreamWriter(CsvPot, true))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord(user);
                    csv.NextRecord();
                }
            }
        }
        public static User[] GetUsers()
        {
            using (var reader = new StreamReader(CsvPot))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<User>().ToArray();
                }
            }
        }



    }
}
