using iReferU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.ViewModels
{
    public class HamburgerViewModel
    {
        public HamburgerViewModel()
        {
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Settings" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Referrals" });
            HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Shop Together" });            
        }

        public List<HamburgerViewItem> HamburgerViewItems { get; set; } = new List<HamburgerViewItem>();
    }
}
