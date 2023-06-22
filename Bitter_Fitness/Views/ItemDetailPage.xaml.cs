using Bitter_Fitness.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Bitter_Fitness.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}