using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InspiringIPTomar.Startup))]
namespace InspiringIPTomar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
