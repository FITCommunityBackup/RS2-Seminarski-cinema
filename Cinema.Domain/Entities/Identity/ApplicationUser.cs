﻿using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Reviews = new List<Review>();
            Reservations = new List<Reservation>();
            News = new List<News>();
            Events = new List<Event>();
            UserRoles = new List<ApplicationUserRole>();
            Claims = new List<ApplicationUserClaim>();
            Logins = new List<ApplicationUserLogin>();
            Tokens = new List<ApplicationUserToken>();
            Deleted = false;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get
            {
                return FirstName + " " + LastName;
            }
        }
        public bool Deleted { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        //Both invoices and reservations will be here - due to polymorphism - Invoice inherits Reservation
        public virtual IList<Reservation> Reservations { get; set; }
        public virtual IList<News> News { get; set; }
        public virtual IList<Event> Events { get; set; }
        //public virtual ApplicationRole Role { get; set; }
        public virtual IList<ApplicationUserRole> UserRoles { get; set; }
        public virtual IList<ApplicationUserClaim> Claims { get; set; }
        public virtual IList<ApplicationUserLogin> Logins { get; set; }
        public virtual IList<ApplicationUserToken> Tokens { get; set; }

    }
}