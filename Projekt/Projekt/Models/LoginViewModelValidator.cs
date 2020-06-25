using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Login)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .Must(x => x != x.ToLower())
                .WithMessage("Hasło musi zawierc przynajmniej jedną wielką literę!")
                .Must(x => x != x.ToUpper())
                .WithMessage("Hasło musi zawierc przynajmniej jedną małą literę!")
                .Matches(@".*\d.*")
                .WithMessage("Hasło musi zawierc conajmniej jedna cyfre!");

            RuleFor(x => x.IsHuman)
                .Must(x => x)
                .WithMessage("Musisz potwierdzic że jestes czlowiekiem!");
        }
    }
}
