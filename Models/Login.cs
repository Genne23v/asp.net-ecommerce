<<<<<<< HEAD
﻿using HPlus_App.Validation;
using System;
=======
﻿using System;
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
<<<<<<< HEAD

namespace HPlus_App.Models
=======
using HPlus_App.Validation;

namespace HPlus.Ecommerce.Models
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
{
    public class Login
    {
        [Required]
<<<<<<< HEAD
        [EmailAddress(ErrorMessage = "User name must be valid email address")]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "This password is too short")]
        [CommonPasswords(ErrorMessage = "This password is too common")]
=======
        [EmailAddress(ErrorMessage = "Usernames must be valid email address")]
        public string Username { get; set; }
        [Required]
        [CommonPassword(ErrorMessage = "This password is too common")]
        [MinLength(8, ErrorMessage = "This password is too short")]
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
        public string Password { get; set; }
    }
}