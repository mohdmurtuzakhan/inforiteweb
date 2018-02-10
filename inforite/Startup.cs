using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inforite.Startup))]
namespace inforite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
