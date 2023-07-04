using Bitter_Fitness.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bitter_Fitness.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Command LoginCommand { get; }
        public Command BackCommand { get; }
        public Command ErrorMessageCheck{ get; }

        private string _userEmail = Preferences.Get("userEmail", null);
        private string _userPassword = Preferences.Get("userPassword", null);
        private string _userName = Preferences.Get("userName", "User");
        private string enteredEmail;
        private string enteredPassword;
        private string errorMessage;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(LoginClicked);
            BackCommand = new Command(BackBtnClicked);
        }
        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; OnPropertyChanged(); }
            
        }
        public string EnteredUserEmail
        {
            get { return enteredEmail; }
            set { enteredEmail = value; }
        }
        public string EnteredUserPassword
        {
            get { return enteredPassword; }
            set { enteredPassword = value; }
        }

        private void LoginClicked(object obj)
        {

            if (!string.IsNullOrEmpty(enteredEmail) && !string.IsNullOrEmpty(enteredPassword))
            {
                if(string.Equals(_userEmail, EnteredUserEmail) && string.Equals(_userPassword, EnteredUserPassword))
                {
                    Debug.WriteLine($"Validation Successful!");
                    ErrorMessage = $"Logged in Successfully Welcome, {_userName}!";
                } else
                {
                    Debug.WriteLine("Validation Unsuccessful...");
                    ErrorMessage = "Unsuccessful login attempt...";
                }
            }
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(LandingPage)}");
        }
        private async void BackBtnClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LandingPage)}");

        }
    }
}
