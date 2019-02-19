using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlz.Startup))]
namespace Vidlz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
