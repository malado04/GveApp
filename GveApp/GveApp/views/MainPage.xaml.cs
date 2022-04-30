using GveApp.views;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GveApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            _ = PermissionAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            App.Current.MainPage = new ShellMain();
           
        }

        public async Task PermissionAsync()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync<LocationPermission>();
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    status = await CrossPermissions.Current.RequestPermissionAsync<LocationPermission>();
                }

                if (status == PermissionStatus.Granted)
                {
                    //Query permission
                }
                else if (status != PermissionStatus.Unknown)
                {
                    //location denied
                }
            }
            catch (Exception ex)
            {
                //Something went wrong
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Console.WriteLine("Tapper 3 fois !");
            Navigation.PushAsync(new AdminConnexionPage());
        }
    }
}
