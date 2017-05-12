using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPISecurityDemo.Startup))]
namespace WebAPISecurityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
