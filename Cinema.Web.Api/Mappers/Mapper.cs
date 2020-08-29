﻿using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.Reservations;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.Requests.Users;

namespace Cinema.Web.Api.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<BaseClass, BaseDto>().Include<Movie, MovieDto>();

            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieUpsertRequest>().ReverseMap();

            CreateMap<ApplicationUser, ApplicationUserDto>();

            CreateMap<ApplicationRole, ApplicationRoleDto>();

            CreateMap<ApplicationUserRole, ApplicationUserRoleDto>();

            CreateMap<ApplicationUser, UserUpsertRequest>().ReverseMap();
            CreateMap<ApplicationUser, UserRegisterRequest>().ReverseMap();
            CreateMap<ApplicationUser, UserSearchRequest>().ReverseMap();

            CreateMap<Genre, GenreDto>();

            CreateMap<GenreMovie, GenreMovieDto>();

            CreateMap<Screening, ScreeningDto>();
            CreateMap<Screening, ScreeningUpsertRequest>().ReverseMap();

            CreateMap<Hall, HallDto>();

            CreateMap<Pricing, PricingDto>();

            CreateMap<Reservation, ReservationDto>();
            CreateMap<Reservation, ReservationUpsertRequest>().ReverseMap();

            CreateMap<Invoice, InvoiceDto>();

            CreateMap<Seat, SeatDto>();
        }
    }
}
