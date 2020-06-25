using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekt.Models
{
    public class Window2ViewModel
    {
        public LoginViewModel Model { get; set; }
        public ICommand LoginCommand { get; set; }
        public Window2ViewModel()
        {
            Model = new LoginViewModel();
            LoginCommand = new LoginCommand();
        }
    }
}
