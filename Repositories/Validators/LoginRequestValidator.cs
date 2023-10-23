using DineWise.Data.DTO;
using FluentValidation;

namespace DineWise.Repositories.Validators
{
    public class LoginRequestValidator : AbstractValidator<LoginRequestDto>
    {
        public LoginRequestValidator() { 
            RuleFor(x=> x.Username).NotEmpty();
            RuleFor(x=> x.Password).NotEmpty();
        }
    }
}
