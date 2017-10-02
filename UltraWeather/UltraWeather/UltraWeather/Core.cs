using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraWeather
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string cityName)
        {
            string key = "b7aa537f5e9ac25b174916109f8f315d";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + cityName + "&units=imperial" + "&appid=" + key;

            var results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.WeatherDescription = (string)results["weather"][0]["description"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.WindSpeed = (string)results["wind"]["speed"] + " mph";
                weather.WindDegree = (string)results["wind"]["deg"] + " degrees";
                weather.Pressure = (string)results["main"]["pressure"] + " hPa";
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
