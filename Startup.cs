using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShopCC.Startup))]
namespace WebShopCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
