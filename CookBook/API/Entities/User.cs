#nullable disable

namespace API.Entities
{
    public  class User: BaseEntity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
