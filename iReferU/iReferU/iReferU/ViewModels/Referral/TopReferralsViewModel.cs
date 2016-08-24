using GalaSoft.MvvmLight.Command;
using iReferU.Interfaces;
using iReferU.Models;
using iReferU.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

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
