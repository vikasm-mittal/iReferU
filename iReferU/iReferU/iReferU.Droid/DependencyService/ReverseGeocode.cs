using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using iReferU.Interfaces.DependencyService;
using iReferU.Models.DependencyService;
using Xamarin.Forms;
using Android.Locations;

[assembly:Dependency(typeof(iReferU.Droid.DependencyService.ReverseGeocode))]
namespace iReferU.Droid.DependencyService
{
    public class ReverseGeocode : IReverseGeocode
    {
        public ReverseGeocode()
        {

        }

        public async Task<LocationAddress> ReverseGeoCodeLatLonAsync(double lat, double lon)
        {
            var geo = new Geocoder(Forms.Context);
            var ispresent = Geocoder.IsPresent;

            IList<Address> addresses = null;
            do
            {
                addresses = await geo.GetFromLocationAsync(lat, lon, 1);
            } while (!addresses.Any());
            
            if (addresses.Any())
            {
                var place = new LocationAddress();
                var add = addresses[0];
                place.Name = add.FeatureName;
                if (add.MaxAddressLineIndex > 0)
                {
                    place.Address1 = add.GetAddressLine(0);
                }
                place.City = add.Locality;
                place.Province = add.AdminArea;
                place.ZipCode = add.PostalCode;
                place.Country = add.CountryCode;
                return place;
            }

            return null;
        }
    }
}