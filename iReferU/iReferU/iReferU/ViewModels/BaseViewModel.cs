using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using iReferU.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.ViewModels
{
    public abstract class BaseViewModel : ViewModelBase
    {
        private bool _isLoading = false;

        public BaseViewModel()
        {
            //this.NavigationService = App.Container.Resolve<INavigationService>();
            LoadedCommand = new RelayCommand(async () => await Loaded());
        }

        public BaseViewModel(INavigationService navigationService)
        {
            LoadedCommand = new RelayCommand(async () => await Loaded());
            this.NavigationService = navigationService;
        }

        public INavigationService NavigationService { get; }

        public RelayCommand LoadedCommand { get; private set; }

        private string _title = "Empty Title";
        public string Title
        {
            get { return this._title; }
            set
            {
                this._title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        protected abstract Task Loaded();

        public bool IsLoading
        {
            get { return this._isLoading; }
            set
            {
                this._isLoading = value;
                RaisePropertyChanged(() => IsLoading);
            }
        }
    }
}
