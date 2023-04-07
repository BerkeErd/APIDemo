using APIDemo.Auth;
using FluentValidation;

namespace APIDemo.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {

        public RegisterValidator()
        {
         RuleFor(c => c.Username).NotEmpty().NotNull().WithMessage("Üye adı boş geçilemez.");
         RuleFor(c => c.Username).MinimumLength(5).WithMessage("Üye adı en az 5 karakter olmalıdır.");

            RuleFor(request => request.Password)
               .NotEmpty()
               .MinimumLength(8)
               .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters.")
               .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters.")
               .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits.")
               .Matches(@"[][""!@$%^&(){}:;<>,.?/+_=|'~\-]").WithMessage("'{PropertyName}' must contain one or more special characters.");

            RuleFor(c => c.Email).NotEmpty().NotNull();
            RuleFor(c => c.Email).EmailAddress();
        }

    }
}
