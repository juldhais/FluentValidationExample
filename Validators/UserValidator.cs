using FluentValidation;
using FluentValidationExample.Resources;

namespace FluentValidationExample.Validators;

public class UserValidator : AbstractValidator<UserResource>
{
    public UserValidator()
    {
        RuleFor(x => x)
            .NotNull();
        
        RuleFor(x => x.Username)
            .NotEmpty()
            .MaximumLength(20);
        
        RuleFor(x => x.Password)
            .NotEmpty()
            .MaximumLength(20);
        
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(50);

        RuleFor(x => x.Age)
            .NotEmpty()
            .Must(x => x >= 17)
            .WithMessage("Minimum age is 17 years old.");
    }
}