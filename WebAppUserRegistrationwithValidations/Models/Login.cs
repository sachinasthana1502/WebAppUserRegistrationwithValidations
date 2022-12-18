using System.ComponentModel.DataAnnotations;
using WebAppUserRegistrationwithValidations.Attributes;

namespace WebAppUserRegistrationwithValidations.Models
{
    public class Login
    {

        [Required(ErrorMessage ="Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password not match")]
        [Required(ErrorMessage = "Please Enter ConfirmPass")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }

        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Contactno")]
        [Required(ErrorMessage = "Enter Contact")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
}
