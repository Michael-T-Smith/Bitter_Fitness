using Bitter_Fitness.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Diagnostics;
using System.Windows.Input;

namespace Bitter_Fitness.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        public Command OnSignupClick { get; }
        public Command OnLoginClick { get; }
        private string _userName;
        private string _userEmail;
        private string _userPassword;
        public SignupViewModel()
        {
            OnSignupClick = new Command(OnSignupClicked);
            OnLoginClick = new Command(OnLoginClicked);
        }

        public string UserEmail
        {
            get { return _userEmail; } set { SetProperty(ref _userEmail, value); }
        }
        public string UserPassword
        {
            get { return _userPassword; } set { SetProperty(ref _userPassword, value); }
        }

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private async void OnSignupClicked(object obj)
        {
            Debug.WriteLine($"Form Input: \nUser Name: {UserName}\nUser Email: {UserEmail}\nUser Password:{UserPassword}");
            Preferences.Set("userName", UserName);
            Preferences.Set("userEmail", UserEmail);
            Preferences.Set("userPassword", UserPassword);

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Application.Current.MainPage.DisplayAlert("Alert", "Sign-Up Clicked, Info Saved, This is the end of the application", "OK");
            await Shell.Current.GoToAsync($"//{nameof(LandingPage)}");
        }
        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
