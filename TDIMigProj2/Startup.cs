using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDIMigProj2.Startup))]
namespace TDIMigProj2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
