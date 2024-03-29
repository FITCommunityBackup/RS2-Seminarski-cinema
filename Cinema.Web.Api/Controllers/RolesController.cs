﻿using Cinema.Common.Interfaces.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;

namespace Cinema.Web.Api.Controllers
{
    public class RolesController : BaseController<ApplicationRoleDto, BaseSearchRequest>
    {
        public RolesController(IService<ApplicationRoleDto, BaseSearchRequest> service) : base(service)
        {
        }
    }
}
