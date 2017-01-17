using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FCClassManagementSystem.Startup))]
namespace FCClassManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
