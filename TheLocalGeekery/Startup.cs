using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheLocalGeekery.Startup))]
namespace TheLocalGeekery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
