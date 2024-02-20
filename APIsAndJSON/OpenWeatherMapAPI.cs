﻿using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    internal class OpenWeatherMapAPI
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
