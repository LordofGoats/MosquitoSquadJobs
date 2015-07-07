using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsonsBlog.Startup))]
namespace CarsonsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
