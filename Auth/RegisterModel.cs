using System.ComponentModel.DataAnnotations;

namespace APIDemo.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Üye ismi boş olamaz.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email boş olamaz")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Parola boş olamaz")]
        public string? Password { get; set; }   
    }
}
