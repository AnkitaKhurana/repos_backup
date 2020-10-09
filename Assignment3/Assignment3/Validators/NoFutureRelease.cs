using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Validators
{
   
    public class NoFutureRelease : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Movie movie = (Movie)validationContext.ObjectInstance;

            if (movie.ReleaseDate > DateTime.Now )
            {               
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
        private string GetErrorMessage()
        {
            return "Cannot add future upcoming movies.";
        }

    }
}
