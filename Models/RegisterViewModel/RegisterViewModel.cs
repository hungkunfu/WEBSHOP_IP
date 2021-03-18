using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopIP.Models.RegisterViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [EmailAddress]
        //[Remote("EmailInUse", "Account", ErrorMessage ="Email da ton tai")]
        public string Email { get; set; }
        [Required]
        // an passwword
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = " Confirm Password not Mach")]
        public string ConfirmPassword { get; set; }
     
       
    }
}
