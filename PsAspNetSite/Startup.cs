using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PsAspNetSite.Startup))]
namespace PsAspNetSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
