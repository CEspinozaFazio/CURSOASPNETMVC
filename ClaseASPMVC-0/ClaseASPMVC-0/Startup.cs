using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaseASPMVC_0.Startup))]
namespace ClaseASPMVC_0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
