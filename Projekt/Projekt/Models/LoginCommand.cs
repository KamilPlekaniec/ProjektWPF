using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Projekt.Models
{
    public class LoginCommand : ICommand
    {
        private LoginViewModelValidator validator = new LoginViewModelValidator();

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            var model = parameter as LoginViewModel;
            if (model is null) return false;
            var resoults = validator.Validate(model);
            model.Errors = string.Join(" ", resoults.Errors);
            return resoults.IsValid;
        }

        public void Execute(object parameter)
        {
            var model = parameter as LoginViewModel;
            MessageBox.Show($"Pomyślnie zalogowano użytkownika {model.Login}", "Powodzenie", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
