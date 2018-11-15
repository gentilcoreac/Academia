using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI.WEB.Startup))]
namespace UI.WEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
