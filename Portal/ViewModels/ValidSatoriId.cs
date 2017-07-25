using System;
using System.ComponentModel.DataAnnotations;

namespace Portal.ViewModels
{
    public class ValidSatoriId : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (string.IsNullOrWhiteSpace(value?.ToString()))
                return false;

            Guid newSatoriId;
            return Guid.TryParse(value.ToString(), out newSatoriId);
        }
    }
}