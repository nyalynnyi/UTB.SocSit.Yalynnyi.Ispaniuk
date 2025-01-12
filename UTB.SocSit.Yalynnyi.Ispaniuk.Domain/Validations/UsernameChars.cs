using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class UsernameCharsAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            else if (value is string text)
            {
                if (text == String.Empty) return ValidationResult.Success;

                if (Regex.IsMatch(text, @"^(?=.*\S)[A-Za-z0-9._]+$")) return ValidationResult.Success;
                else return new ValidationResult($"The {validationContext.MemberName} field contains not allowed symbols.");
            }
            else
            {
                throw new NotImplementedException($"The {nameof(UsernameCharsAttribute)} is not implemented for the type: {value.GetType()}");
            }
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (context.Attributes.ContainsKey("data-val") == false)
                context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-usernamechars", $"The {context.ModelMetadata.Name} field contains not allowed symbols: #$%&'()*+,-\\/:;<=>?@[]^_`{{|}}~\"");
        }
    }
}
