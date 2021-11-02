using Airlinesal.BO;
using Airlinesal.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Airlinesal.UnitTests
{
    public class BookingBOTests
    {
        private Customer customer1;
        Seat seat1 = new Seat();
        Seat seat2 = new Seat();
        List<Seat> seats;
        List<Flight> flights;
        Airplane airplane1;
        Flight flight1;
        Flight flight2;
        Reservation reservation;

        [SetUp]
        public void Setup()
        {
            customer1 = new Customer()
            {
                Name = "Joao", Country = "Brazil", Province = "Sao Paulo",
                DateOfBirth = new DateTime(1980, 02, 05), Email = "joao@email.com"
            };

            seat1 = new Seat() { Id = 1, Description = "window" };
            seat2 = new Seat() { Id = 2, Description = "corridor" };
            seats = new List<Seat>();
            seats.Add(seat1);
            seats.Add(seat2);

            airplane1 = new Airplane()
            {
                Id = 1, Description = "Boing 50", seats = seats
            };

            flight1 = new Flight()
            {
                Id = 1, From = "Sao Paulo", To = "Panama City", DateTimeToFlight = new DateTime(2021, 10, 15), Airplane = airplane1
            };

            flight2 = new Flight()
            {
                Id = 1,
                From = "Sao Paulo",
                To = "Chile",
                DateTimeToFlight = new DateTime(2021, 10, 15),
                Airplane = airplane1
            };

            flights = new List<Flight>();
            flights.Add(flight1);

            reservation = new Reservation();

        }

        [Test]
        public void IsFlightAvailable_WhenCustomerSearchUnavailableFlight_ReturnFalse()
        {
            ////arrange
            //reservation.customer = customer1;
            //reservation.Flight = flight1;
            //reservation.Airplane = airplane1;
            //reservation.FlightClass = FlightClass.Basic.ToString();
            //reservation.Seat = seat1;

            //act
            bool isFlightAvailable = BookingBO.IsFlightAvailble(flight2);

            //assert
            Assert.IsFalse(isFlightAvailable);
        }

        [Test]
        public void IsFlightAvailable_WhenCustomerSearchAvailableFlight_ReturnTrue()
        {
            //act
            bool isFlightAvailable = BookingBO.IsFlightAvailble(flight1);

            //assert
            Assert.IsTrue(isFlightAvailable);
        }

    }
}