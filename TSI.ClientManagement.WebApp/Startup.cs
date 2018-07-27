using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSI.ClientManagement.WebApp.Startup))]
namespace TSI.ClientManagement.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
