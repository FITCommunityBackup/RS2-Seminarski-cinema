﻿using Cinema.Common.Interfaces;
using Cinema.Models.Requests.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    [Route("api")]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IUserService _userService;
        public AuthController(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        #region Login Validation  
        /// <summary>  
        /// Login Authenticaton using JWT Token Authentication  
        /// </summary>  
        /// <param name="data"></param>  
        /// <returns></returns>  
        [AllowAnonymous]
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login([FromBody] LoginRequest data)
        {

            IActionResult response = Unauthorized();
            var user = await _userService.Authenticate(data.UserName, data.Password);
            if (user != null)
            {
                var tokenString = _userService.GenerateJSONWebToken(user);
                response = Ok(new { Message = "Success", Token = tokenString });
            }
            else
            {
                response = Unauthorized(new { Message = "Invalid credentials provided." });
            }
            return response;
        }
        #endregion

        [AllowAnonymous, HttpGet(nameof(Decode))]
        public List<string> Decode([FromQuery] string token)
        {
            return _userService.DecodeJSONWebToken(token);
        }

    }
}
