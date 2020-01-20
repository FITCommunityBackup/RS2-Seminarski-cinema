﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.BLL;
using System.Security.Claims;
using Cinema.Web.Helpers;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Web.Pages.ReservationTickets
{
    public class IndexModel : CinemaPageModel
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;

        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context)
        {
            _seatingService = new SeatingService(unit);
            _pricingService = new PricingService(unit);
        }

        [BindProperty]
        public Hall CurrentHall { get; set; }
        [BindProperty]
        public Screening CurrentScreening { get; set; }
        [BindProperty]
        public List<SeatingModel> ScreeningSeats { get; set; }
        [BindProperty]
        public string ReservedSeats { get; set; }
        [BindProperty]
        public Pricing PricingTier { get; set; }
        [BindProperty, HiddenInput, Required]
        public string SelectedSeatsString { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, long date)
        {
            ViewData["successMessage"] = "";
            ViewData["errorMessage"] = "";
            var screeningDate = new DateTime(date);
            CurrentHall = await unit.Halls.GetAsync(id);

            CurrentScreening = CurrentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);

            //CurrentScreening = _context.Halls.FirstOrDefault(x => x.Id == id).Screenings
                //.FirstOrDefault(x => x.DateAndTime == ScreeningDate);

            ScreeningSeats = _seatingService.GetScreeningSeating(CurrentScreening);

            ReservedSeats = string.Join(",", _seatingService.ReservedSeats);
            PricingTier = _pricingService.GetPricingTier("Premiere");


            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id, long date)
        {
            ViewData["successMessage"] = "";
            ViewData["errorMessage"] = "";
            var screeningDate = new DateTime(date);
            CurrentHall = await unit.Halls.GetAsync(id);

            CurrentScreening = CurrentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);

            ScreeningSeats = _seatingService.GetScreeningSeating(CurrentScreening);
            ReservedSeats = string.Join(",", _seatingService.ReservedSeats);
            PricingTier = _pricingService.GetPricingTier("Premiere");

            if (!ModelState.IsValid)
            {
                ViewData["errorMessage"] = "Model is invalid.";
                return Page();
            }

            var selectedSeats = SelectedSeatsString.Split(',').Select(Int32.Parse).ToList();
            
            
            if (selectedSeats == null)
            {
                ViewData["errorMessage"] = "You haven't picked your seats.";
                return Page();
            }

            if (await _seatingService.MaybeSeatsReservedAsync(selectedSeats, screeningDate, id) != true)
            {
                ViewData["errorMessage"] = "One of the seats that you are trying to book is reserved. Please try different seat.";
                return Page();
            }

            Reservation reservation = new Reservation
            {
                User = unit.Users.Get(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                Screening = CurrentScreening
            };

            unit.Reservations.Insert(reservation);

            await unit.SaveAsync();

            foreach(int seatId in selectedSeats)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Seat = unit.Seats.Get(seatId),
                    Reservation = reservation
                };

                unit.SeatReservations.Insert(seatReservation);
            }

            await unit.SaveAsync();

            ViewData["successMessage"] = "You have sucesufully reserved your tickets.";
            return RedirectToPage();
        }
    }
}