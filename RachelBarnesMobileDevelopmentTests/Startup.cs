using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RachelBarnesMobileDevelopmentTests.Startup))]
namespace RachelBarnesMobileDevelopmentTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
