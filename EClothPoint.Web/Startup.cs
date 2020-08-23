using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EClothPoint.Web.Startup))]
namespace EClothPoint.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
