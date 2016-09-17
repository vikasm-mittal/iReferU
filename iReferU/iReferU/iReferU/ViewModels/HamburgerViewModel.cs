
using iReferU.Interfaces;
using iReferU.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iReferU.ViewModels
{
    public class HamburgerViewModel : BaseViewModel
    {
        public HamburgerViewModel()
        { 
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Find Referrals" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Submit a Referral" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "My Referrals" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Sign in" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Sign out" });            
        }

        public List<HamburgerViewItem> HamburgerViewItems { get; set; } = new List<HamburgerViewItem>();

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
