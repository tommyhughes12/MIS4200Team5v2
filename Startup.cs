using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200Team5v2.Startup))]
namespace MIS4200Team5v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
