using System.ComponentModel.DataAnnotations;

namespace BurgerMVCProject.UI.Models.AccountModels
{
    public class LoginVM
    {
        //[Required(ErrorMessage = "Kullanıcı Adı bilgisi girilmelidir.")]
        //[RegularExpression(@"^[^\s!@#$%^&*(),.?:{}|<>]+$", ErrorMessage = "Username must not contain special characters.")]
        [Required]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Ad bilgisi girilmelidir.")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        //[Required(ErrorMessage = "Soyad bilgisi girilmelidir.")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Email bilgisi girilmelidir.")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Parola bilgisi girilmelidir.")]
        [Required]
        public string Password { get; set; }
        //[Required(ErrorMessage = "AYnı Parola bilgisi girilmelidir.")]
        [Required]
        public string RepeatPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}
