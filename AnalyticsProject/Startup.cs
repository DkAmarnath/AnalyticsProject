using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnalyticsProject.Startup))]
namespace AnalyticsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
