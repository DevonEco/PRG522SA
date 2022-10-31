using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522_SA.Startup))]
namespace PRG522_SA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
