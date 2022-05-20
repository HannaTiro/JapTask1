using System;

namespace API.Filters
{
    public class UserException:Exception
    {
        public UserException(string msg) : base(msg)
        {

        }
    }
}
