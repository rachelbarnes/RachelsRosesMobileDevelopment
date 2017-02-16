using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RachelBarnesMobileDevelopment.Startup))]
namespace RachelBarnesMobileDevelopment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
