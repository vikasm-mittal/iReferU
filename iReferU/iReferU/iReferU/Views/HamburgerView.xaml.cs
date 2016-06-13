using iReferU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iReferU.Views
{
    public partial class HamburgerView : ContentPage
    {
        public HamburgerView()
        {
            InitializeComponent();

            //HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Settings" });
            //HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Referrals" });
            //HamburgerViewItems.Add(new HamburgerViewItem() { Title = "Shop Together" });

            //listView.ItemsSource = HamburgerViewItems;
        }

        public List<HamburgerViewItem> HamburgerViewItems { get; set; } = new List<HamburgerViewItem>();
    }
}
