using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlinesal.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Email { get; set; }
    }
}
