using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSarajevoPrevoz.Startup))]
namespace eSarajevoPrevoz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
