using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPProjekat.Startup))]
namespace ASPProjekat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
