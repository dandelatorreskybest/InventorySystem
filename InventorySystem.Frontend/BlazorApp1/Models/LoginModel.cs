using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class LoginModel
    {
        // [Required(ErrorMessage = "Email is required")]
        // [EmailAddress(ErrorMessage = "Invalid email address")]


        // [Required(ErrorMessage = "Password is required")]
        // [DataType(DataType.Password)]

        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

    }
}
