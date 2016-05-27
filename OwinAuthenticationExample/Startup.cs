using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OwinAuthenticationExample.Startup))]
namespace OwinAuthenticationExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
