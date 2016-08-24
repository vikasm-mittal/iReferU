using iReferU.Interfaces;
using iReferU.Services;
using iReferU.ViewModels.Referral;
using iReferU.Views;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace iReferU
{
    public partial class App : Application
    {
        private static IUnityContainer _container = null;
        public static IUnityContainer Container { get { return _container; } }

        public App()
        {
            InitializeComponent();

            _container = new UnityContainer();
            Container.RegisterType<INavigationService, NavigationService>(new ContainerControlledLifetimeManager());

            Container.RegisterType<TopReferralsViewModel>();
            Container.RegisterType<SearchReferralsViewModel>();
            Container.RegisterType<FilterReferralsViewModel>();
            Container.RegisterType<ReferralDetailsViewModel>();

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
