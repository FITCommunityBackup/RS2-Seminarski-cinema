﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Events;
using Cinema.Services.Enums;
using Cinema.Services.Factory.ViewModels;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    public class EventsController : BaseController
    {
        public EventsController(ApplicationDbContext context) : base(context) { }

        [AllowAnonymous]
        public async Task<IActionResult> Index(SortOrder? sortOrder, string sortProperty, string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<Event> eventsQuery = _unit.Events.Get();

            if (!String.IsNullOrEmpty(searchString))
            {
                eventsQuery = eventsQuery.Where(x => x.Title.Contains(searchString));
            }

            if (sortOrder != null)
            {
                sortOrder = sortOrder == SortOrder.ASC ? SortOrder.DESC : SortOrder.ASC;
                eventsQuery = _unit.Events.Sort(eventsQuery, sortOrder, sortProperty);
            }
            else
            {
                sortOrder = SortOrder.ASC;
                eventsQuery = eventsQuery.OrderBy(s => s.Title);
            }

            List<EventIndexVM> events = await eventsQuery.Select(x => x.ToIndexVM()).ToListAsync();

            PaginatedList<EventIndexVM> paginatedModel
                = PaginatedList<EventIndexVM>.Create(events.AsQueryable(), pageNumber ?? 1, 10,
                sortOrder, sortProperty, searchString);

            return View(paginatedModel);
        }
    }
}