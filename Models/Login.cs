using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HPlus_App.Validation;

namespace HPlus.Ecommerce.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "Usernames must be valid email address")]
        public string Username { get; set; }
        [Required]
        [CommonPassword(ErrorMessage = "This password is too common")]
        [MinLength(8, ErrorMessage = "This password is too short")]
        public string Password { get; set; }
    }
}