using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeQuote}");

            Console.WriteLine();
        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(ronURL).Result;
            string ronQuote = JArray.Parse(ronResponse).ToString().Replace('[',' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");
        }

        public static void Convo()
        {
            for (int i = 0; i < 5; i++)
            {
                KanyeQuote();
                RonQuote();
            }
        }
    }
}
