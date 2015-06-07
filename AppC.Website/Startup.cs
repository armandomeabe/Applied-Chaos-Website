using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppC.Website.Startup))]
namespace AppC.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
