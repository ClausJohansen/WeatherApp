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

            ScrollView s = new ScrollView();
            
            for(int i = 0; i < model.Days.Count; i++)
            {
                DateTime day = model.Days[i];
                ColumnDefinition cd = new ColumnDefinition { Width = 100 };

                daysGrid.ColumnDefinitions.Add(cd);
                daysGrid.Children.Add(new DayView(), i, 0);
            }
        }
    }
}
