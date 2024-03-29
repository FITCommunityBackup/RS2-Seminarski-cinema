﻿using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Dal
{
    public interface ICinemaDbContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<EventType> EventTypes { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<GenreMovie> GenreMovies { get; set; }
        DbSet<Hall> Halls { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<News> News { get; set; }
        DbSet<NewsType> NewsTypes { get; set; }
        DbSet<Pricing> Pricing { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Screening> Screenings { get; set; }
        DbSet<Seat> Seats { get; set; }
        DbSet<SeatReservation> SeatReservations { get; set; }
        DbSet<ApplicationUser> Users { get; set; }
        DbSet<ApplicationRole> Roles { get; set; }
        DbSet<ApplicationUserRole> UserRoles { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        void Dispose();
    }
}
