using iReferU.Interfaces;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class SearchReferralsViewModel : BaseViewModel
    {
        public SearchReferralsViewModel() { }

        public SearchReferralsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Search";
        }

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
