using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public static class APICaller
    {
        public static string GetWeatherFromOpenWeather(string city)
        {
            var client = new RestClient("https://api.openweathermap.org/data/2.5/");
            var request = new RestRequest("weather/", Method.GET);
            request.AddParameter("q", city);
            request.AddParameter("appid", "53507e4723aa2d6092fcb310e4be8fbc");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }
    }
}
