using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class LoginViewModel : ViewModelBase
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (_login != value)
                {
                    _login = value;
                    NotifyPropertyChanged("Login");
                }

            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    NotifyPropertyChanged("Password");
                }

            }
        }
        private bool _isHuman;

        public bool IsHuman
        {
            get { return _isHuman; }
            set
            {
                if (_isHuman != value)
                {
                    _isHuman = value;
                    NotifyPropertyChanged("IsHuman");
                }

            }
        }
        private string _errors;

        public string Errors
        {
            get { return _errors; }
            set
            {
                if (_errors != value)
                {
                    _errors = value;
                    NotifyPropertyChanged("Errors");
                }

            }
        }
    }
}
