using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZUB.Startup))]
namespace ZUB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
