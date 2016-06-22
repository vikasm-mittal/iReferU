using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class SearchReferralsViewModel : BaseViewModel
    {
        public SearchReferralsViewModel()
        {
            Title = "Search";
        }

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
