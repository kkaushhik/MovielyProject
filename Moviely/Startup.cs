using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviely.Startup))]
namespace Moviely
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
