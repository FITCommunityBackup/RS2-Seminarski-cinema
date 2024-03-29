﻿using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Controllers
{
    public class EventTypesController : BaseController<EventTypeDto, BaseSearchRequest>
    {
        public EventTypesController(IService<EventTypeDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
