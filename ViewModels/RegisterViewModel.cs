﻿using System.ComponentModel.DataAnnotations;

namespace IdentityApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]  
         public string Email { get; set; }
        [Required]
        [Display(Name ="UserName")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Passwords aren't matching")]
        public string ConfirmPassword { get; set;}

        public string? ReturnUrl { get; set; }
    }
}
