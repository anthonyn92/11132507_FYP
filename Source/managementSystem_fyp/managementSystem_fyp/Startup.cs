using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(managementSystem_fyp.Startup))]
namespace managementSystem_fyp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
