﻿using Cinema.Domain.Entities.Identity;
using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Reservation : BaseClass
    {
        public Reservation()
        {
            SeatReservations = new List<SeatReservation>();
        }

        public bool IsCancelled { get; set; }
        public string ReservationCode { get; set; }
        public int TicketQuantity { get; set; }

        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ScreeningId { get; set; }
        public virtual Screening Screening { get; set; }

        public int? InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public virtual IList<SeatReservation> SeatReservations { get; set; }
    }
}