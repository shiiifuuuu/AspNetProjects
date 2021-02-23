using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBMS.Startup))]
namespace SBMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
