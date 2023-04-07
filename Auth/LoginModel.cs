using System.ComponentModel.DataAnnotations;

namespace APIDemo.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Üye ismi boş olamaz")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Parola boş olamaz")]
        public string? Password { get; set; }
    }
}
