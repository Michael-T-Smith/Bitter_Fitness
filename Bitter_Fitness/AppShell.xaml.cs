using Bitter_Fitness.ViewModels;
using Bitter_Fitness.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Bitter_Fitness
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
