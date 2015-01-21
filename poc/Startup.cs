using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(poc.Startup))]
namespace poc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
