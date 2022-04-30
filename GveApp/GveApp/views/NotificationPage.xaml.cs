using GveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GveApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        List<Notification> listeDesNotification = new List<Notification>();        
        public NotificationPage()
        {
            InitializeComponent();
            listeDesNotification = new List<Notification>()
            {
                new Notification()
                {
                    Id =1,
                    Date =DateTime.Today,
                    Message = "Notification 1",
                },
                new Notification()
                {
                    Id =1,
                    Date =DateTime.Today,
                    Message = "Notification 2",
                },
                new Notification()
                {
                    Id =1,
                    Date =DateTime.Today,
                    Message = "Notification 3",
                },
            };
            list_des_notification.ItemsSource = listeDesNotification;
        }
    }
}