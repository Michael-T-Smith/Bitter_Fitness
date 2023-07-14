using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitter_Fitness.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        private void GenerateMessageButton_Clicked(object sender, EventArgs e)
        {
            // Generate a random message
            string[] messages = { "To see you Seize the Day", "Because he knew Milk comes from cows", "To Keep on Keeping on", "Because you can Do it better than the next guy", "to tell you it Takes 30 days to make a habit", "to make you Have belief in yourself", "to whisper... Your future self will be grateful", "To Do 50 Pushups", "He buckled under the pressure" };
            Random random = new Random();
            string randomMessage = messages[random.Next(messages.Length)];

            // Modify the button text and appearance
            Button button = (Button)sender;
            button.Text = randomMessage;
            button.BackgroundColor = Color.Green;
            button.TextColor = Color.White;
            
        }

    }
}