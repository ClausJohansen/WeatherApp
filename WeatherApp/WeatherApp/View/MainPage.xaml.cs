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
        private MainViewModel model;

        public MainPage(MainViewModel model)
        {
            this.model = model;
            BindingContext = this.model;

            InitializeComponent();
        }
    }
}
