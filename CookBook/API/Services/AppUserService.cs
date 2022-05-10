using API.Entities;
using API.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AppUserService:IAppUserService
    {
        private readonly IMapper _mapper;
        private readonly CookBookContext _context;

        public AppUserService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Models.AppUser Authenticiraj(string username, string pass)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var hashedPass = Helper.HashGenerator.GenerateHash(user.PasswordSalt,pass); 

                if (hashedPass == user.PasswordHash)
                {
                   
                    Models.AppUser newUser = new Models.AppUser();



                    newUser.FirstName = user.FirstName;
                    newUser.LastName = user.LastName;
                    newUser.Username = user.Username;
                  

                    return newUser;
                }
            }
            return null;
        }

        public List<Models.AppUser> GetUsers()
        {
            var query = _context.AppUsers.AsQueryable();

           
            var list = query.ToList();

            return _mapper.Map<List<Models.AppUser>>(list);
        }

    }
}
