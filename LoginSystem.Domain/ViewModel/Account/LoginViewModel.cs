using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoginSystem.Domain.ViewModel.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter name")]
        [MinLength(4, ErrorMessage = "Name must be longer than 4 characters")]
        [MaxLength(20, ErrorMessage = "Name must be less than 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
