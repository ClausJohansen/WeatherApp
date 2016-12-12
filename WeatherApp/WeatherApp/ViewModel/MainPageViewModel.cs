using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Entity;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // Properties

        public Weather TodayNow { get; set; } // prob. collection...?


        // The rest
        private readonly MainPageModel model;

        public MainPageViewModel(MainPageModel model)
        {
            this.model = model;
        }

        // INotifyPropertyChanged stuff...
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler evt = PropertyChanged;

            if (evt != null)
            {
                evt(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
