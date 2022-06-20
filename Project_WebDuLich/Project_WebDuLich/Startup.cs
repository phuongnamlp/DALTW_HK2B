using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_WebDuLich.Startup))]
namespace Project_WebDuLich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
