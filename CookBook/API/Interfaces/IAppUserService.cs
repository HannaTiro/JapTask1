using API.Requests.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public interface IAppUserService
    {
        Models.AppUser Authenticiraj(string username, string pass);
        List<Models.AppUser> GetUsers();
    }
}
