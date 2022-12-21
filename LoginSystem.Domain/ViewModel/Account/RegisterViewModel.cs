using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Domain.ViewModel.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter name")]
        [MinLength(4, ErrorMessage = "Name must be longer than 4 characters")]
        [MaxLength(20, ErrorMessage = "Name must be less than 20 characters")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password")]
        [MinLength(6, ErrorMessage = "Password must be longer than 6 characters")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string PasswordConfirm { get; set; }
    }
}
