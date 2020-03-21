﻿using Cinema.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    class SeatsTest : TestBase
    {
        [Test, Order(1)]
        [TestCase(20)]
        public async Task GetSeatLabel(int id)
        {
            Seat seat = await unit.Seats.GetAsync(id);
            Assert.AreEqual("A5", seat.Label);
        }
    }
}
