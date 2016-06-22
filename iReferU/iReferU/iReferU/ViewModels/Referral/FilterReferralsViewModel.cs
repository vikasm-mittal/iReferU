using System;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class FilterReferralsViewModel : BaseViewModel
    {
        public FilterReferralsViewModel()
        {
            Title = "Filter";
        }

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
