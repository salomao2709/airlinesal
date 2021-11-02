using Airlinesal.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlinesal.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class BookingController : Controller
    {
        public IEnumerable<Flight> Get()
        {
            List<Flight> flights = new List<Flight>();
            Flight flight = new Flight();
            flight.Id = 1;
            flight.From = "Sao Paulo";
            flight.To = "Montreal";
            flights.Add(flight);
            return flights;
        }



    }
}
