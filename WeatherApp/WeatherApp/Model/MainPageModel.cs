using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Entity;
using WeatherApp.Model.Network;

namespace WeatherApp.Model
{
    public class MainPageModel
    {
        private DataService service;

        public MainPageModel(DataService service)
        {
            this.service = service;
        }

        public async Task<Weather> GetWeather(string cityName)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "108a3baa8fb4cbb2cb73871c6da5442e";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + cityName + ",dk&appid=" + key;

            var results = await service.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}
