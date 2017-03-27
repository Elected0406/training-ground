using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(training_ground.Startup))]
namespace training_ground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
