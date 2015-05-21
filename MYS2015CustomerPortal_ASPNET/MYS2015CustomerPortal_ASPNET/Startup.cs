using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MYS2015CustomerPortal_ASPNET.Startup))]
namespace MYS2015CustomerPortal_ASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
