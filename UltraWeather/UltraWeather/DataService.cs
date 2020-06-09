using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UltraWeather
{
    public static class DataService
    {
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(queryString);

                dynamic data = null;
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}