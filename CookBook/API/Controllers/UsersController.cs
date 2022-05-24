using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
           
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Models.User Authenticiraj(string username, string password)
        {
            return _userService.Authenticiraj(username, password);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/users")]
        public List<Models.User> GetUsers()
        {
            return _userService.GetUsers();
        }


    }
}
