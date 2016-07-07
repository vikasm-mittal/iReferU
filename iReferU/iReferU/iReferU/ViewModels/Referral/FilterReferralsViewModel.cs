using iReferU.Interfaces;
using System;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class FilterReferralsViewModel : BaseViewModel
    {
        public FilterReferralsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Filter";
        }

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
