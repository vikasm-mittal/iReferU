using iReferU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace iReferU.ViewModels.Referral
{
    public class ReferralsViewModel : BaseViewModel
    {
        public ReferralsViewModel()
        {
            TabItems.Add(App.Container.Resolve<TopReferralsViewModel>());
            TabItems.Add(App.Container.Resolve<SearchReferralsViewModel>());
            TabItems.Add(App.Container.Resolve<FilterReferralsViewModel>());
        }

        public List<BaseViewModel> TabItems { get; set; } = new List<BaseViewModel>();

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
