using API.Entities;
using API.Filters;
using API.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class UserService:IUserService
    {
        private readonly IMapper _mapper;
        private readonly CookBookContext _context;

        public UserService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public async Task<Models.AppUser> Login(LoginRequest request)
        //{
        //    var user = _context.AppUsers.FirstOrDefault(x => x.Username == request.Username);
        //    if (user == null)
        //    {
        //        throw new UserException("Wrong username or password");
        //    }
        //    if (user != null)
        //    {
        //        var hash = Helper.HashGenerator.GenerateHash(user.PasswordSalt, request.Password);

        //        if (hash != user.PasswordHash)
        //        {
        //            throw new UserException("Pogrešan username ili password");

        //        }

        //    }
        //    return _mapper.Map<Models.AppUser>(user);
        //}
        public Models.User Authenticiraj(string username, string pass)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.UserName == username);
           
            if (user != null) 
            {
                var hashedPass = Helper.HashGenerator.GenerateHash(user.PasswordSalt,pass); 

                if (hashedPass == user.PasswordHash)
                {
                   
                    Models.User newUser = new Models.User();



                    newUser.FirstName = user.FirstName;
                    newUser.LastName = user.LastName;
                    newUser.UserName = user.UserName;
                    newUser.Id = user.Id;

                  

                    return newUser;
                }
                //else if(hashedPass!=user.PasswordHash)
                //{

                //   // throw new UserException("Pogrešan username ili password");
                    
                //}
            }
            return null;
        }

        public List<Models.User> GetUsers()
        {
            var query = _context.AppUsers.AsQueryable();

           
            var list = query.ToList();

            return _mapper.Map<List<Models.User>>(list);
        }

    }
}
