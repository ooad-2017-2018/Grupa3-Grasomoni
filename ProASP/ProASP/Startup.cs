using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProASP.Startup))]
namespace ProASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
