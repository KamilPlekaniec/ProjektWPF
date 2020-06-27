using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Login)
                .NotNull()
                .WithMessage("Pole login nie może być puste!")
                .NotEmpty()
                .WithMessage("Pole login nie może być puste!")
                .EmailAddress()
                .WithMessage("Pole login musi zawierać format poprawny dla adresu e-mail!");
                

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("Pole hasło nie może być puste!")
                .NotEmpty()
                .WithMessage("Pole hasło nie może być puste!")
                .MinimumLength(6)
                .WithMessage("Pole hasło musi mieć minimum 6 znaków!")
                .Must(x => x != x.ToLower())
                .WithMessage("Hasło musi zawierać przynajmniej jedną wielką literę!")
                .Must(x => x != x.ToUpper())
                .WithMessage("Hasło musi zawierać przynajmniej jedną małą literę!")
                .Matches(@".*\d.*")
                .WithMessage("Hasło musi zawierać co najmniej jedną cyfrę!");

            RuleFor(x => x.IsHuman)
                .Must(x => x)
                .WithMessage("Musisz potwierdzić że nie jesteś robotem!");
        }
    }
}
