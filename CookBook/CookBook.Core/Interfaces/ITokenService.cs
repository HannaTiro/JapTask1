using CookBook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Core.Interfaces
{
   public interface ITokenService
    {
        Task<string> CreateToken(User user);
    }
}
