using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HRSystem.Models
{
    public class DateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime DateValue = Convert.ToDateTime(value);
            if(value != null )
            {
                if (DateValue < DateTime.Now)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(base.ErrorMessage);
                }
                    
            }
            else
            {
                return new ValidationResult(base.ErrorMessage);
            }
        }
    }
}