using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Validation.Models;

namespace Validation.Validators
{
    public class DateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Appointment appointment = (Appointment)validationContext.ObjectInstance;

            if (appointment.StartDate > appointment.EndDate)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return "Start Date should not exceed End Date";
        }
    }
}