using iReferU.ViewModels.Referral;
using iReferU.Views.Referral;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace iReferU.Views.Common
{
    public class ReferralDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TopReferralsViewModel)
            {
                return TopReferralsDataTemplate;
            }
            else if (item is SearchReferralsViewModel)
            {
                return SearchReferralsDataTemplate;
            }
            else if (item is FilterReferralsViewModel)
            {
                return FilterReferralsDataTemplate;
            }

            return null;
        }

        public DataTemplate TopReferralsDataTemplate { get; set; }
        public DataTemplate SearchReferralsDataTemplate { get; set; }
        public DataTemplate FilterReferralsDataTemplate { get; set; }        
    }
}
