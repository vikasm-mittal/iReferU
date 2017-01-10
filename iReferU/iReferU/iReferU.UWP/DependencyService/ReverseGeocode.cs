using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iReferU.Interfaces.DependencyService;
using iReferU.Models.DependencyService;
using Windows.Devices.Geolocation;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(iReferU.Droid.DependencyService.ReverseGeocode))]
namespace iReferU.Droid.DependencyService
{
    public class ReverseGeocode : IReverseGeocode
    {
        public ReverseGeocode()
        {

        }

        public async Task<LocationAddress> ReverseGeoCodeLatLonAsync(double lat, double lon)
        {
            var accessStatus = await Geolocator.RequestAccessAsync();

            return null;
        }
    }
}