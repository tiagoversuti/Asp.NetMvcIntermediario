using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcNWind.Startup))]
namespace MvcNWind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
