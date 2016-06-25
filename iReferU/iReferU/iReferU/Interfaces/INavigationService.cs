using iReferU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.Interfaces
{
    public interface INavigationService
    {
        Task PopAsync();
        Task PopModalAsync();
        Task PushAsync(BaseViewModel viewModel);
        Task PushModalAsync(BaseViewModel viewModel);
        Task PopToRootAsync();
    }
}
