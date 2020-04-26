using System.Threading.Tasks;

namespace UltraWeather
{
    internal interface ICoreDAO
    {
        Task<Weather> GetWeather(string cityName);
    }
}