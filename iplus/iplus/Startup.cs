using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iplus.Startup))]
namespace iplus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
