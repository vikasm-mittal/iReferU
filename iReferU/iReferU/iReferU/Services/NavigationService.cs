using iReferU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iReferU.ViewModels;
using Xamarin.Forms;
using System.Reflection;
using iReferU.Views.Referral;
using iReferU.ViewModels.Referral;

namespace iReferU.Services
{
    public class NavigationService : INavigationService
    {
        private INavigation _navigation = null;
        private Dictionary<Type, Type> _viewsMapping = new Dictionary<Type, Type>();

        public NavigationService()
        {
            RegisterViews();
        }
        
        public Task PopAsync()
        {
            //App.Current.MainPage.Navigation
            throw new NotImplementedException();
        }

        public Task PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public async Task PushAsync(BaseViewModel viewModel)
        {
            if (_navigation == null)
            {
                _navigation = App.Current.MainPage.Navigation;
            }

            Type viewType;
            if (_viewsMapping.TryGetValue(viewModel.GetType(), out viewType))
            {
                var concreteView = Activator.CreateInstance(viewType);
                if (concreteView is ContentPage)
                {
                    (concreteView as ContentPage).BindingContext = viewModel;
                    await _navigation.PushModalAsync(concreteView as ContentPage);
                }
            }
        }

        public Task PushModalAsync(BaseViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void RegisterViews()
        {
            _viewsMapping.Add(typeof(ReferralDetailsViewModel), typeof(ReferralDetailsView));
        }
    }
}
