using System.Collections.Generic;

namespace CookBook.Core.Interfaces
{
    public interface IUserService
    {
        Models.User Authenticiraj(string username, string pass);
        List<Models.User> GetUsers();
    }
}
