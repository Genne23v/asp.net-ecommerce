﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlus_App.Validation
{
    public class CommonPasswordAttribute : ValidationAttribute
    {
        private string _errorMessage = null;
        private string[] badPasswords = new[] {
            "111111",
            "12345",
            "123456",
            "1234567",
            "12345678",
            "123456789",
            "abc123",
            "password",
            "password1",
            "qwerty"
        };

        public CommonPasswordAttribute(string errorMessage = null)
        {
            _errorMessage = errorMessage;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;

            return !badPasswords.Contains(value.ToString());
        }

        public override string FormatErrorMessage(string name)
        {
            return _errorMessage ?? $"{name} is too common!";
        }
    }
}