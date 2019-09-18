using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;
using System.Web.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Ajax.Utilities;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var weatherData = await getDataFromService("");
            return View();
        }

        public static async Task<string> getDataFromService(string queryString)
        {

            var client = new HttpClient();
            string result = "";

            try
            {
                var response = await client.GetAsync(queryString).ConfigureAwait(false);
                if (response != null)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                Console.WriteLine(error);
            }
            return result;
        }

        public async Task<ActionResult> GetWeather(float latitude, float longitude)
        {
            var apiKey = WebConfigurationManager.AppSettings["dsKey"];
            var dsLink = $"https://api.darksky.net/forecast/{apiKey}/{latitude},{longitude}";

            var result = await getDataFromService(dsLink);
            var betterResult = JsonConvert.DeserializeObject<Rootobject>(result);

            WeatherViewModel wvm = new WeatherViewModel();
            wvm.currently.temperature = betterResult.currently.temperature;
            wvm.currently.summary = betterResult.currently.summary;
            wvm.currently.windSpeed = betterResult.currently.windSpeed;
            wvm.currently.humidity = betterResult.currently.humidity;
            wvm.currently.precipProbability = betterResult.currently.precipProbability;
            wvm.currently.icon = betterResult.currently.icon;

            wvm.hourly.data = betterResult.hourly.data.Take(8).ToArray();
            wvm.hourly.summary = betterResult.hourly.summary;

            wvm.daily.data = betterResult.daily.data.Take(8).ToArray();
            wvm.daily.summary = betterResult.daily.summary;

            return Json(wvm);
        }
    }
}
