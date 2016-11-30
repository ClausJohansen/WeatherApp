using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string CurrentDateTimeString
        {
            get
            {
                DateTime currentTime = DateTime.Now;
                return currentTime.ToString("D");
            }
        }

        public List<DateTime> Days { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            // Adding some data here for temperary showing while developing.
            // I'm assuming that this should be set by the MVVM model wich in turn gets it from the weather service.

            Days = new List<DateTime>();

            // Let's assume 1 weeks forecast capability.
            // We then add 7 days to the list of days, starting from today (weather forecast for yesterday and before is not very interesting).
            for(int i = 0; i < 7; i++)
            {
                Days.Add(DateTime.Today.AddDays(i));
            }
            
        }
    }
}
