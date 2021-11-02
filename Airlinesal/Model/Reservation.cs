using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlinesal.Model
{
    public class Reservation
    {
        public Customer customer { get; set; }
        public Flight Flight { get; set; }
        public string FlightClass { get; set; }
        public Airplane Airplane { get; set; }
        public Seat Seat { get; set; }
    }
}
