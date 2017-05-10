using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cn.lovelong.FreeCodeCamp.Startup))]
namespace cn.lovelong.FreeCodeCamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
