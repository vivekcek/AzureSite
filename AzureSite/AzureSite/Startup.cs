using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureSite.Startup))]
namespace AzureSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
