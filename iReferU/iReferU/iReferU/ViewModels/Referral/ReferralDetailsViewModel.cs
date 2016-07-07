using iReferU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class ReferralDetailsViewModel : BaseViewModel
    {
        public ReferralDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        protected override Task Loaded()
        {
            throw new NotImplementedException();
        }
    }
}
