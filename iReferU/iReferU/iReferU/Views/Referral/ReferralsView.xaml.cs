using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace iReferU.Views.Referral
{
    public partial class ReferralsView : TabbedPage
    {
        public ReferralsView()
        {
            InitializeComponent();

            this.Children.Add(new NavigationPage(new TopReferralsView())
            {
                Title = "Top"
            });

            this.Children.Add(new NavigationPage(new SearchReferralsView())
            {
                Title = "Search"
            });
        }
    }
}
