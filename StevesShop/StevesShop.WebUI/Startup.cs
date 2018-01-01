using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StevesShop.WebUI.Startup))]
namespace StevesShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
