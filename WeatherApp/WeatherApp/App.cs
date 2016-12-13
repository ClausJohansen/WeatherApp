using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Model;
using WeatherApp.Model.Network;
using WeatherApp.View;
using WeatherApp.ViewModel;
using Xamarin.Forms;

namespace WeatherApp
{
    public class App : Application
    {
        public App()
        {
            // MainPage = new NavigationPage(new WeatherPage());
            var apiConnection = new DataService();
            var model = new MainPageModel(apiConnection);
            var viewModel = new MainPageViewModel(model);

            MainPage = new MainPage(viewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
