using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Projekt.Models
{
    public class ViewModel : ViewModelBase
    {
        private User _user;
        private ObservableCollection<User> _users;
        private ICommand _SubmitCommand;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }
        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyPropertyChanged("Users");
            }
        }
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit(),
                        null);
                }
                return _SubmitCommand;
            }
        }
        public ViewModel()
        {
            User = new User();
            Users = new ObservableCollection<User>();
            Users.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Users_CollectionChanged);
        }
        void Users_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Users");
        }
        private void Submit()
        {
            User.JoiningDate = DateTime.Today.Date;
            Users.Add(User);
            User = new User();
        }
    }
}
