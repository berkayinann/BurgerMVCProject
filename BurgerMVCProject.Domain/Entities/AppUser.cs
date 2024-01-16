using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BurgerMVCProject.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Kullanıcı Adı bilgisi girilmelidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Ad bilgisi girilmelidir.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad bilgisi girilmelidir.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email bilgisi girilmelidir.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Parola bilgisi girilmelidir.")]
        public string Password { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
