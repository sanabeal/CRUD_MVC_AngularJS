using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDMVCAngularJS.Startup))]
namespace CRUDMVCAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
