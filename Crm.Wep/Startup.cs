using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crm.Wep.Startup))]
namespace Crm.Wep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
