using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class ReferralsViewModel : BaseViewModel
    {
        public ReferralsViewModel()
        {
            TabItems.Add(new TopReferralsViewModel());
            TabItems.Add(new SearchReferralsViewModel());
            TabItems.Add(new FilterReferralsViewModel());
        }

        public List<BaseViewModel> TabItems { get; set; } = new List<BaseViewModel>();

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
