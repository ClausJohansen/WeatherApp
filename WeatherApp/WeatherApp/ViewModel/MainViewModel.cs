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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
