
using iReferU.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iReferU.ViewModels
{
    public class HamburgerViewModel : BaseViewModel
    {
        public HamburgerViewModel()
        {
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Settings" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Referrals" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Shop Together" });            
        }

        public List<HamburgerViewItem> HamburgerViewItems { get; set; } = new List<HamburgerViewItem>();

        protected override async Task Loaded()
        {
            await Task.Yield();
        }
    }
}
