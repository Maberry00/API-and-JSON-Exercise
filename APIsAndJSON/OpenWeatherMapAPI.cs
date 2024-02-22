using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void CurrentWeather()
        {
            var client = new HttpClient();

            var key = "2599c158177decfe5bb8988ed3979643";
            var city = "Jackson";
            //var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={key}&units=imperial";
            var weatherEndpoint = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";
            var response = client.GetStringAsync(weatherEndpoint).Result;

            JObject formattedResponse = JObject.Parse(response);
            var temp = formattedResponse["main"]["temp"];
            Console.WriteLine($"{city}:{temp}");
        }
    }
}
