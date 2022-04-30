using GveApp.Models;
using GveApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;


namespace GveApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public Position p;
        public MapPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                getPostion();

                return true; // True = Repeat again, False = Stop the timer
            });
        }
        public class ItemsPosition
        {
            public string colierm { get; set; }
            public string longitude { get; set; }
            public string latitude { get; set; }
        }

        List<GveApp.Models.PositionModule> list_position;
        public async void getPostion()
        {
            RestService service = new RestService();

            string[] coliers = new string[]
                {
                "colier 1", "colier2","colier3"
                };

            Position position_colier1 = new Position(1, 1);

            List<Position> listPositions = new List<Position>();
             
            foreach (string colier in coliers)
            {
                
            }

            var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "https://ipmie.com/api/positions";
            client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var ItemsPositions = JsonConvert.DeserializeObject<List<ItemsPosition>>(content);
            //Position position_colier1= new Position(ItemsPosition Items);
            MyMap.ItemsSource = ItemsPositions;


            // MyMap.Pins.Clear();

            var location = await Geolocation.GetLastKnownLocationAsync();

            p = new Position(location.Latitude, location.Longitude);

            Pin pin = new Pin()
            {
                Position = p,
                Label = "Position GVE",

            };
             foreach (var ItemsPosition in ItemsPositions)
             {
                if (list_position.Count > 0)
                { 
                    position_colier1 = new Position(Convert.ToDouble(ItemsPosition.latitude), Convert.ToDouble(ItemsPosition.longitude));
                    listPositions.Add(position_colier1);
                }
            }

            var i = 0;
            foreach (Position position in listPositions)
            {
                i++;
                Pin pin2 = new Pin()
                {
                    Position = position,
                    Label = "Colier " + i,
                };

                MyMap.Pins.Add(pin2);

                MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                  position, Distance.FromMiles(.3)));

                Circle circle = new Circle()
                {
                    Center = position,
                    Radius = new Distance(300),
                    StrokeColor = Color.FromHex("#88FF0000"),
                    StrokeWidth = 8,
                    FillColor = Color.FromHex("#88FFC0CB")
                };
                MyMap.Circles.Clear();
                MyMap.Circles.Add(circle);
            }
        }
    }
}