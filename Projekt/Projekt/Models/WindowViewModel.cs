using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt.Models
{
    public class WindowViewModel
    {
        public RegisterViewModel Model { get; set; }
        public ICommand LoginCommand { get; set; }
        public WindowViewModel()
        {
            Model = new RegisterViewModel();
            LoginCommand = new RegisterCommand();
        }
    }
}
