using HPlus_App.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlus_App.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "User name must be valid email address")]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "This password is too short")]
        [CommonPasswords(ErrorMessage = "This password is too common")]
        public string Password { get; set; }
    }
}