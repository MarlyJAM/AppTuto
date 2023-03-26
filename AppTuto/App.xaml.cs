using System;
using Xamarin.Essentials;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppTuto.Repository;

namespace AppTuto
{
    public partial class App : Application
    {
        string dbPath= Path.Combine(FileSystem.AppDataDirectory,"database.db3");
        public static UserRepository UserRepository { get; private set; }
        public App()
        {
            InitializeComponent();
            UserRepository = new UserRepository(dbPath);

            MainPage = new MainPage();
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
