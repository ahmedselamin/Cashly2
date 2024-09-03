﻿using Cashly.Server.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace Cashly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authController : ControllerBase
    {
        private readonly IAuthService _authService;

        public authController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var response = await _authService.Register(
                new User
                {
                    Username = request.Username
                },
                request.Password);

            if (response.Success)
            {
                return BadRequest(response.Message);
            }

            return Ok(response);
        }
    }
}
