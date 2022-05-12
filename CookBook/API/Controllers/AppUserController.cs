using API.DTOs;
using API.Entities;
using API.Interfaces;
using API.Models;
using API.Requests.AppUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
 
    [ApiController]
    [Route("api/[controller]")]

    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _service;
       

        public AppUserController(IAppUserService service)
        {
            _service = service;
           
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Models.AppUser Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }




        [HttpGet]
        [AllowAnonymous]
        [Route("api/users")]
        public List<Models.AppUser> GetUsers()
        {
            return _service.GetUsers();
        }


    }
}
