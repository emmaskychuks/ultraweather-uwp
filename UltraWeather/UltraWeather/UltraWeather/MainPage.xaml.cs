using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltraWeather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Ultra Weather Application";
            getWeatherBtn.Clicked += GetWeather_Clicked;

            this.BindingContext = new Weather();
        }

        private async void GetWeather_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cityNameEntry.Text))
            {
                Weather weather = await Core.GetWeather(cityNameEntry.Text);
                if (weather != null)
                {
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Search Again";
                }
                else
                {
                    getWeatherBtn.Text = "Ooops!, try again";
                }
            };
        }
    }
}
