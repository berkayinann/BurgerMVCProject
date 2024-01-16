using Microsoft.AspNetCore.Identity;

namespace BurgerMVCProject.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int MyProperty { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
