﻿using Cinema.BLL;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cinema.Test.BLLTests
{
    [TestFixture]
    class ReservationServiceTests : TestBase
    {
        SeatingService seatingService;
        private static object[] sourceLists = 
            {
                new object[] {32, new List<int> { 309, 408 } },  //case 1
                new object[] {41, new List<int> { 364, 384, 451, 302, 424, 390 } } //case 2
            };

        [Test, Order(1), TestCaseSource("sourceLists")]
        public void GetScreeningSeating(Screening screening, List<int> reservedSeats)
        {
            //Arrange
            seatingService = new SeatingService(unit.Context);
            List<SeatingModel> seating = seatingService.GetScreeningSeating(screening);

            //Act
            int numberOfReservations = seating.Where(x => x.Reserved == true).Count();
            //Assert
            //There are 240 seats in the screening hall
            Assert.AreEqual(240, seating.Count);
            //There are 2 reservations in the test screening
            Assert.AreEqual(reservedSeats.Count, numberOfReservations);

            //Checks if all seats that have a reservation are found in the seating as reserved
            foreach(int seatId in reservedSeats)
            {
                Assert.IsNotNull(seating.FirstOrDefault(x => x.Seat.Id == seatId && x.Reserved == true));
            }
        }
    }
}
