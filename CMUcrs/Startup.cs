using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMUcrs.Startup))]
namespace CMUcrs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
