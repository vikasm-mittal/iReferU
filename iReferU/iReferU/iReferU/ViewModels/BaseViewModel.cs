using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
            LoadedCommand = new RelayCommand(async () => await Loaded());
        }

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
