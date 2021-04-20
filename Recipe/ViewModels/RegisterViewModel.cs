using System.ComponentModel.DataAnnotations;

namespace Recipe.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm password should be the same as Password!")]
        public string ConfirmPassword { get; set; }
    }
}