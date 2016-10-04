using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.NetMvcIntermediario.Startup))]
namespace Asp.NetMvcIntermediario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
