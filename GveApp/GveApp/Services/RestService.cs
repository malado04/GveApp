using GveApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GveApp.Services
{
    public class RestService
    {
        private readonly string Base_url = "https://www.ipmie.com/esp/public/index.php/api/";
        HttpClient Client;
        //Liste des rendez-vous
        public async Task<List<PositionModule>> GetPositionAsync(string colier)
        {
            List<PositionModule> list = new List<PositionModule>();
            try
            {
                HttpClient Client = new HttpClient();
                var response = await Client.GetStringAsync(Base_url + "position/" + colier);
                list = JsonConvert.DeserializeObject<List<PositionModule>>(response);
                Console.Write( "=================>" + response);
            }
            catch (Exception ex)
            {
                Console.WriteLine( "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm>" + ex.Message);
            }
            return list;
        }
    }
}
