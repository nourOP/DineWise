using DineWise.Data.DTO;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace DineWise.Repositories.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequestDto>
    {
        public RegisterRequestValidator() {
            RuleFor(x=> x.Email).EmailAddress(EmailValidationMode.Net4xRegex);
            RuleFor(x=>x.Phonenumber)
                .MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
                .MaximumLength(10).WithMessage("PhoneNumber must not exceed 10 characters.International Numbers are not currently supported")
                .Matches(new Regex(@"^\d{10}$")).WithMessage("PhoneNumber not valid");
        }
    }
}
