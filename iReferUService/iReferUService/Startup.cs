using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(iReferUService.Startup))]

namespace iReferUService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}