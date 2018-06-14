using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCZK.Startup))]
namespace MVCZK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
