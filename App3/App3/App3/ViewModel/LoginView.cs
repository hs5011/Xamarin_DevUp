using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3.ViewModel
{
    class LoginView : INotifyPropertyChanged
    {
        private string _user;
        private string _pass;

        public string user
        {
            get => _user; set
            {
                if (_user != value)
                {
                    _user = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User"));
                    
                }
            }
        }
        public string pass123 { get => _pass; set => _pass = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        public LoginView()
        {
            LoginCommand = new Command(Login, CanLogin);
        }
        
        public void ChangePass()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(pass123)));
        }
        public ICommand LoginCommand { get; set; }
        private void Login()
        {

        }
        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass123);
        }
    }
}
