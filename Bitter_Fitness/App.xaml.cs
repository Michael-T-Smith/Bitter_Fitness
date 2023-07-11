using Bitter_Fitness.Services;
using Bitter_Fitness.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitter_Fitness
{
    public partial class App : Application

    {

        private static Database database;

        /* Creates and maintains one database connection.*/
        /* Change Environment Special Folder path to desired location for storing database file(s).*/
        /* Reference https://youtu.be/uxqQqyuZ3Qo?t=600 for more implementation details */
        public static Database Database
        {
            get
            {
                if (database == null) 
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }

                return database;
            }

        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
