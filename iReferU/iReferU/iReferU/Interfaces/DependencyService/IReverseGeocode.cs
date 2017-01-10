using iReferU.Models.DependencyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.Interfaces.DependencyService
{
    public interface IReverseGeocode
    {
        Task<LocationAddress> ReverseGeoCodeLatLonAsync(double lat, double lon);
    }
}
