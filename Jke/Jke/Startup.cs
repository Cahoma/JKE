using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jke.Startup))]
namespace Jke
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
