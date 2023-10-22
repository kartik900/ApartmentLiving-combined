using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwtAuthenticationApi.Models;
using JwtAuthenticationApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthenticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(LoginController));
        private readonly IAuthenticationManager manager;

        private readonly CommunityGateDatabaseContext context;
        public LoginController(IAuthenticationManager manager)
        {
            this.manager = manager;
        }



        [AllowAnonymous]
        [HttpPost("AuthenicateUser")]
        public IActionResult AuthenticateUser([FromBody] LoginDetails loginDetails)
        {
            _log4net.Info(" Http Authentication request Initiated");
            var token = manager.Authenticate(loginDetails.Username, loginDetails.Password,loginDetails.LoginType);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }

    }
}
