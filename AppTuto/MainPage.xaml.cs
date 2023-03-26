using AppTuto.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTuto
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SetButtonClicked (object sender, EventArgs e)
        {
            statusMessage.Text = "";
            await App.UserRepository.AddNewUserAsync(newUser.Text);

            statusMessage.Text = App.UserRepository.StatusMessages;
        }
        private async void GetButtonClicked (object sender, EventArgs e)
        {
            statusMessage.Text = "";
            List<User> users= await App.UserRepository.GetUsersAsync();
            foreach (var user in users)
            {
                Console.WriteLine($" {user.Id} - {user.Name}");
            }
            statusMessage.Text = App.UserRepository.StatusMessages;
        }
    }
    
}
