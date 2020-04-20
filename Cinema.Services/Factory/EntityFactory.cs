﻿using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Events;
using Cinema.DTO.ViewModels.Movies;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.DTO.ViewModels.Screenings;
using Cinema.DTO.ViewModels.Users;
using System.Collections.Generic;
using System.Linq;

namespace Cinema.Services.Factory
{
    public static class EntityFactory
    {
        public static Movie Create(this MovieCreateVM movie)
        {
            return new Movie
            {
                Title = movie.Title,
                Duration = movie.Duration,
                Actors = movie.Actors,
                Directors = movie.Directors,
                Year = movie.Year,
                Country = movie.Country,
                Image = movie.Image,
                VideoLink = movie.VideoLink
            };
        }

        public static Screening Create(this ScreeningCreateVM screening)
        {
            return new Screening
            {
                MovieId = screening.MovieId,
                HallId = screening.HallId,
                DateAndTime = screening.DateAndTime
            };
        }

        public static Review Create(this ReviewCreateVM review)
        {
            return new Review
            {
                MovieId = review.Movie.Id,
                UserId = review.UserId,
                Rating = review.Rating
            };
        }

        public static Review Create(this ReviewUpdateVM review)
        {
            return new Review
            {
                Id = review.Id,
                MovieId = review.Movie.Id,
                UserId = review.UserId,
                Rating = review.Rating
            };
        }

        public static Review Create(this ReviewIndexVM review)
        {
            return new Review
            {
                Id = review.ReviewId,
                MovieId = review.Movie.Id,
                UserId = review.User.Id,
                Rating = review.Rating
            };
        }

        public static ApplicationUser Create(this ApplicationUserCreateVM user)
        {
            return new ApplicationUser
            {
                Email = user.Email,
                UserName = user.Email,
                EmailConfirmed = true,
                PhoneNumber = user.PhoneNumber,
                PhoneNumberConfirmed = true,
                FirstName = user.FirstName,
                LastName = user.LastName,
                NormalizedEmail = user.Email.ToUpper(),
                NormalizedUserName = user.Email.ToUpper()
            };
        }

        public static void Update(this ApplicationUserCreateVM userModel, ApplicationUser user)
        {
            user.UserName = userModel.Email;
            user.EmailConfirmed = true;
            user.PhoneNumber = userModel.PhoneNumber;
            user.PhoneNumberConfirmed = true;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.NormalizedEmail = userModel.Email.ToUpper();
            user.NormalizedUserName = userModel.Email.ToUpper();
        }

        public static Event Create(this EventCreateVM model)
        {
            return new Event
            {
                AuthorId = model.AuthorId,
                Description = model.Description,
                Title = model.Title,
                DateAndTime = model.DateAndTime,
                Promoter = model.Title,
                TypeId = model.EventTypeId
            };
        }
    }
}
