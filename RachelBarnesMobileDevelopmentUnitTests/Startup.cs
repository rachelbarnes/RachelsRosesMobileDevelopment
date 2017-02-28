using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RachelBarnesMobileDevelopmentUnitTests.Startup))]
namespace RachelBarnesMobileDevelopmentUnitTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
