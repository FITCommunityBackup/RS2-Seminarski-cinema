﻿using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class ScreeningRepository : Repository<Screening, int>
    {
        public ScreeningRepository(ApplicationDbContext context) : base(context) { }

        public bool ValidateScreeningDate(Screening screening)
        {
            return screening.DateAndTime >= DateTime.UtcNow;
        }

        public async Task<bool> ValidateScreeningHallAvailabilityAsync(Screening validatedScreening)
        {
            Hall hall = await _context.Halls.FindAsync(validatedScreening.HallId);
            Movie movie = await _context.Movies.FindAsync(validatedScreening.MovieId);

            if (hall == null || movie == null) return false;

            DateTime validatedStartTime = validatedScreening.DateAndTime;
            DateTime validatedEndTime = validatedScreening.DateAndTime.AddMinutes(movie.Duration);

            var hallScreenings = hall.Screenings.Where(x => x.DateAndTime.Date == validatedStartTime.Date).ToList();

            foreach (var screening in hallScreenings)
            {
                DateTime startTime = screening.DateAndTime;
                DateTime endTime = screening.DateAndTime.AddMinutes(screening.Movie.Duration);

                if (validatedStartTime >= startTime && validatedStartTime <= endTime) return false;
                if (validatedEndTime >= startTime && validatedEndTime <= endTime) return false;
            }

            return true;
        }
    }
}
