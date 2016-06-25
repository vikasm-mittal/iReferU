using iReferU.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iReferU.ViewModels;
using Xamarin.Forms;

namespace iReferU.Services
{
    public class NavigationService : INavigationService
    {
        private INavigation _navigation = null;
        
        public Task PopAsync()
        {
            //App.Current.MainPage.Navigation
        }

        public Task PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(BaseViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(BaseViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
