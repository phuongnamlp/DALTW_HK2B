using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Travel.Startup))]
namespace Project_Travel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
