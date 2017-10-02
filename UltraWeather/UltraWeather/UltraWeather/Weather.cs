using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraWeather
{
    public class Weather
    {
        public string Title { get; set; }
        public string WeatherDescription { get; set; }
        public string Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string WindDegree { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }


        public Weather()
        {
            Title = " ";
            WeatherDescription = " ";
            Temperature = " ";
            WindSpeed = " ";
            WindDegree = " ";
            Pressure = " ";
            Humidity = " ";
            Visibility = " ";
            Sunrise = " ";
            Sunset = " ";
        }
    }
}
