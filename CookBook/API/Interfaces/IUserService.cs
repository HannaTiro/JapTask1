using System.Collections.Generic;

namespace API.Interfaces
{
    public interface IUserService
    {
        Models.User Authenticiraj(string username, string pass);
        List<Models.User> GetUsers();
    }
}
