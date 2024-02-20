using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMap
    {
        var client = new HttpClient();

        var key = "2599c158177decfe5bb8988ed3979643";

        var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={key}&units=imperial";
        var response = client.GetStringAsync(weatherURL).Result;

        JObject formattedResponse = JObject.Parse(response);
        var temp = formattedResponse["list"][0]["main"]["temp"];
        Console.WriteLine(temp);
    }
}
