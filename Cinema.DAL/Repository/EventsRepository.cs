﻿using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Services.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class EventsRepository : Repository<Event, int>
    {
        public EventsRepository(ApplicationDbContext context) : base(context) { }

        public override IQueryable<Event> Sort(IQueryable<Event> query, SortOrder? sortOrder, string sortProperty)
        {
            if (sortOrder == SortOrder.ASC)
            {
                switch (sortProperty)
                {
                    case "Title":
                        query = query.OrderBy(s => s.Title);
                        break;
                    case "Date":
                        query = query.OrderBy(s => s.DateAndTime);
                        break;
                    case "Time":
                        query = query.OrderBy(s => s.DateAndTime.TimeOfDay);
                        break;
                    case "Description":
                        query = query.OrderBy(s => s.Description);
                        break;
                    case "Type":
                        query = query.OrderBy(s => s.Type.Name);
                        break;
                }
            }
            else
            {
                switch (sortProperty)
                {
                    case "Title":
                        query = query.OrderByDescending(s => s.Title);
                        break;
                    case "Date":
                        query = query.OrderByDescending(s => s.DateAndTime);
                        break;
                    case "Time":
                        query = query.OrderByDescending(s => s.DateAndTime.TimeOfDay);
                        break;
                    case "Description":
                        query = query.OrderByDescending(s => s.Description);
                        break;
                    case "Type":
                        query = query.OrderByDescending(s => s.Type.Name);
                        break;
                }
            }

            return query;
        }

    }
}