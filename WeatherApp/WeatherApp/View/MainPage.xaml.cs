using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherApp.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // await GetData();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Weather data = await Core.GetWeather("Odense");

            lblCity.Text = data.Title;
            lblDate.Text = data.Humidity;
        }
    }
}
