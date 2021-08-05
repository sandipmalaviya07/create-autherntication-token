using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthDemo.Model;
using AuthDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("auth")]
        public async Task<IActionResult> GetAuthToken()
        {
            AuthService authService = new AuthService();
            var token = authService.GetAuthToken();
            return Ok(token);
        }
    }
}
