using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Checklist.Web.Startup))]
namespace Checklist.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
