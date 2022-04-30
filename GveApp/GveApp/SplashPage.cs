using System;
using System.Collections.Generic;
using System.Text;
using GveApp.views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GveApp
{
    
    public class SplashPage : ContentPage
    {
        readonly Image SlpashImage;
       
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            SlpashImage = new Image
            {
                Source = "gve_logo.png",
                HeightRequest = 100,
                WidthRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(SlpashImage, 
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SlpashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(SlpashImage);
            this.BackgroundColor = Color.White;
            this.Content = sub;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await SlpashImage.ScaleTo(1, 2000);
            await SlpashImage.ScaleTo(0.5,2000, Easing.Linear) ;
            await SlpashImage.ScaleTo(1, 1000);
            //await SlpashImage.ScaleTo(4,50, Easing.Linear) ;
            //var current = Connectivity.NetworkAccess;
            Application.Current.MainPage = new NavigationPage(new MainPage());
            //Application.Current.MainPage = new NavigationPage(new RegisterPage());
            //Application.Current.MainPage = new NavigationPage(new LoginPage());
            //if (current != NetworkAccess.Internet)
            //{
            //    //await DisplayAlert("Erreur", "Vérifier votre connexion internet", "OK");
            //    Application.Current.MainPage = new NavigationPage(new NoConnexionPage());
            //}
            //else
            //{
            //    Application.Current.MainPage = new ShellMainPage();
            //}
            

        }
    }
}
