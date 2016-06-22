using iReferU.Models;
using iReferU.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace iReferU.ViewModels.Referral
{
    public class TopReferralsViewModel : BaseViewModel
    {
        private bool _isLoadingFirstTime = true;

        public TopReferralsViewModel()
        {
            Title = "Top";
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title2" });
            //_referralItems.Add(new ReferralItem() { Title = "Title3" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title10" });
            //_referralItems.Add(new ReferralItem() { Title = "Title11" });
            //_referralItems.Add(new ReferralItem() { Title = "Title12" });
            //_referralItems.Add(new ReferralItem() { Title = "Title13" });
            //_referralItems.Add(new ReferralItem() { Title = "Title14" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title1" });
            //_referralItems.Add(new ReferralItem() { Title = "Title21" });
            //_referralItems.Add(new ReferralItem() { Title = "Title31" });
            //_referralItems.Add(new ReferralItem() { Title = "Title41" });
        }

        private ObservableCollection<ReferralItem> _referralItems = new ObservableCollection<ReferralItem>();

        public ObservableCollection<ReferralItem> ReferralItems { get { return this._referralItems; } }

        protected override async Task Loaded()
        {
            if (_isLoadingFirstTime)
            {
                _isLoadingFirstTime = false;
                var items = await ReferralItemServiceManager.DefaultInstance.GetItemsAsync();
                foreach (var item in items)
                {
                    ReferralItems.Add(item);
                }
            }
        }
    }
}
