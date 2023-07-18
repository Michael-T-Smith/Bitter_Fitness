using Bitter_Fitness.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Diagnostics;

namespace Bitter_Fitness.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignupCommand { get; }

        public LandingViewModel()
        {
            LoginCommand = new Command(OnLoginClicked); 
            SignupCommand = new Command(OnSignupClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        private async void OnSignupClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync(nameof(SignupPage));
        }
    }
}
