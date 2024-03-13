using Microsoft.AspNetCore.Identity;

namespace DBPorachkaMebeli.Data
{
    public class Client:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateModidied { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }
    }
}
