using iReferU.Views;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace iReferU
{
    public partial class App : Application
    {

        public IUnityContainer Container { get; }

        public App()
        {
            InitializeComponent();


            Container = new UnityContainer();

            Container.RegisterType<INavigationService>

            // The root page of your application
            MainPage = new MainView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
