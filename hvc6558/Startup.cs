using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hvc6558.Startup))]
namespace hvc6558
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
