using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timeclock.Startup))]
namespace Timeclock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
