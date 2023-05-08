using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Broker_Project
{
    internal class Price
    {
        public string timestamp { get; set; }
        public float open { get; set; }
        public float close { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public int volume { get; set; }

    }
}
