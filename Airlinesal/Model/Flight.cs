using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlinesal.Model
{
    public class Flight
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DateTimeToFlight { get; set; }
    }
}
