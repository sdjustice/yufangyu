using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WMS3_S.Startup))]
namespace WMS3_S
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
