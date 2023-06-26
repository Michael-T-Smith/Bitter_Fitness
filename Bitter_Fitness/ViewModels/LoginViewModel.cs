using Bitter_Fitness.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Bitter_Fitness.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignupCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked); 
            SignupCommand = new Command(OnSignupClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
        private async void OnSignupClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync(nameof(SignupPage));
        }
    }
}
