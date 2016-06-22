using iReferU.Common;
using iReferU.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.Services
{
    public class BaseServiceManager<T, U> 
        where T : BaseModel
        where U : BaseServiceManager<T, U>, new()
    {
        protected BaseServiceManager()
        {
            this._client = new MobileServiceClient(Constants.ApplicationURL);
            this._tableData = _client.GetTable<T>(); 
        }

        private IMobileServiceTable<T> _tableData = null;
        private MobileServiceClient _client = null;
        private static BaseServiceManager<T, U> defaultInstance = new U();

        public IMobileServiceTable<T> TableData
        {
            get { return this._tableData; }
            set { this._tableData = value; }
        }

        public static BaseServiceManager<T, U> DefaultInstance
        {
            get { return defaultInstance; }
        }

        public MobileServiceClient CurrentClient
        {
            get { return this._client; }
        }

        public async Task<ObservableCollection<T>> GetItemsAsync(bool syncItems = false)
        {
            IEnumerable<T> items = await _tableData.ToEnumerableAsync();
            return new ObservableCollection<T>(items);
        }
    }
}
