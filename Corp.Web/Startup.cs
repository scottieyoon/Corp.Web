using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Corp.Web.Startup))]
namespace Corp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
