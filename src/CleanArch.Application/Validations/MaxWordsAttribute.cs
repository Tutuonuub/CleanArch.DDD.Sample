using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CleanArch.Application.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MaxWordsAttribute : ValidationAttribute
    {
        private readonly int _maxWords;
        public MaxWordsAttribute(int maxWords)
        {
            _maxWords = maxWords;
        }

        public override bool IsValid(object? value)
        {
            if (value == null) return true;
            if (value is string s)
            {
                var words = s.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length <= _maxWords;
            }
            return true;
        }
    }
}
