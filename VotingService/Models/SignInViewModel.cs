using System;
using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "Login is Required")]
        [RegularExpression(@"admin", ErrorMessage = "User does not exist")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"123", ErrorMessage = "Wrong password")]
        public String Password { get; set; }
    }
}