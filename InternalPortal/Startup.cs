using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternalPortal.Startup))]
namespace InternalPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
