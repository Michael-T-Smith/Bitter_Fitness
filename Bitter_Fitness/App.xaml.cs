using Bitter_Fitness.Services;
using Bitter_Fitness.Views;
using System;
using System.Linq.Expressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitter_Fitness
{

    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new ProfilePage(); //Toggle between different pages and views to code from
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
