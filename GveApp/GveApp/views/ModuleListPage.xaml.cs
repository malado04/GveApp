using GveApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GveApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModuleListPage : ContentPage
    {
        List<Module> listeDesModule = null;
        public ModuleListPage()
        {
            InitializeComponent();
            LoadData();

        }

        public class ItemModule
        {
            public int Id { get; set; }
            public string num_col { get; set; }
            public string libelle_col { get; set; }
        }
        private async void LoadData()
        {
            var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "https://ipmie.com/api/modules";  
            client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<ItemModule>>(content);
            liste_de_modules.ItemsSource = Items;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddModulePage());
        }
    }
}