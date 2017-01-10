using GalaSoft.MvvmLight.Command;
using iReferU.Interfaces;
using iReferU.Models;
using iReferU.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Practices.Unity;
using Plugin.Geolocator;
using Xamarin.Forms.Maps;

namespace iReferU.ViewModels.Referral
{
    public class TopReferralsViewModel : BaseViewModel
    {
        private bool _isLoadingFirstTime = true;

        public TopReferralsViewModel() { }

        public RelayCommand<bool> SwitchViewCommand { get; private set; }

        private bool _isMapView = false;
        public bool IsMapView
        {
            get { return _isMapView; }
            set
            {
                _isMapView = value;
                RaisePropertyChanged(() => IsMapView);
            }
        }

        public TopReferralsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Referrals made easy";
            SwitchViewCommand = new RelayCommand<bool>(x => IsMapView = x);

            for (int i = 0; i < 10; i++)
            {
                _referralItems.Add(new ReferralItem()
                {
                    Title = "Dish Savings",
                    ShortDescription = "Save 50 dollars for dish"
                });
            }
        }        

        private ObservableCollection<ReferralItem> _referralItems = new ObservableCollection<ReferralItem>();

        public ObservableCollection<ReferralItem> ReferralItems { get { return this._referralItems; } }

        private ReferralItem _selectedReferral = null;
        public ReferralItem SelectedReferral
        {
            get { return this._selectedReferral; }
            set
            {
                this._selectedReferral = value;
                RaisePropertyChanged(() => SelectedReferral);

                if (value == null)
                {
                    return;
                }

                NavigationService.PushAsync(App.Container.Resolve<ReferralDetailsViewModel>());
            }
        }

        protected override async Task Loaded()
        {
            if (_isLoadingFirstTime)
            {
                try
                {

                    var locator = CrossGeolocator.Current;
                    locator.DesiredAccuracy = 50;

                    var position = await locator.GetPositionAsync(10000);

                    var geoCoder = new Geocoder();
                    var address = await geoCoder.GetAddressesForPositionAsync(new Position(position.Latitude, position.Longitude));

                    //var service = DependencyService.Get<IReverseGeocode>();
                    //var location = await service.ReverseGeoCodeLatLonAsync(position.Latitude, position.Longitude);

                    System.Diagnostics.Debug.WriteLine("---------- Location --------- :" + address.ToList().FirstOrDefault().ToString());                                       

                    IsLoading = true;
                    _isLoadingFirstTime = false;
                    var items = await ReferralItemServiceManager.DefaultInstance.GetItemsAsync();
                    foreach (var item in items)
                    { 
                        ReferralItems.Add(item);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    IsLoading = false;
                }
            }
        }
    }
}
