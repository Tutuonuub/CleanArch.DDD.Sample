using System;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class NotOnlyWhiteSpaceAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return true; // use [Required] para obrigatoriedade
            if (value is string s)
            {
                return !string.IsNullOrWhiteSpace(s);
            }
            return true;
        }
    }
}
