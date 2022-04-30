using GveApp.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GveApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SplashPage();
            //MainPage = new MainPage();
            //MainPage = new ShellMain();
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
