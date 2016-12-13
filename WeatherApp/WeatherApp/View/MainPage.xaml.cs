using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.ViewModel;
using Xamarin.Forms;

namespace WeatherApp.View
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel model;

        public MainPage(MainPageViewModel model)
        {
            this.model = model;
            BindingContext = this.model;

            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            // Weather data = await Model.GetWeather("Odense");

            //lblCity.Text = data.Title;
            //lblDate.Text = data.Humidity;
        }
    }
}
