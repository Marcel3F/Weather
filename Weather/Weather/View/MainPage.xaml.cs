using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.ViewModel;
using Xamarin.Forms;

namespace Weather.View
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();
        }

        public async void OnClicked(object o, EventArgs e)
        {
            var longitude = double.Parse(Lon.Text);
            var latitude = double.Parse(Lat.Text);

            var url = string.Format("http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username=marcel3f", latitude, longitude);
            await vm.GetWeatherAsync(url);
        }
    }
}
