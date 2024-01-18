using System.ComponentModel.DataAnnotations;

namespace BurgerMVCProject.UI.Models
{
    public class UserVm
    {

        [Required(ErrorMessage = "Kullanıcı Adı bilgisi girilmelidir.")]

        [RegularExpression(@"^[^\s!@#$%^&*(),.?:{}|<>]+$", ErrorMessage = "Username must not contain special characters.")]
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
        [Required(ErrorMessage = "AYnı Parola bilgisi girilmelidir.")]
        public string RepeatPassword { get; set; }


    }
}