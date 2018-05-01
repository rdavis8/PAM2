using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvalusAssetManagement.Startup))]
namespace ProvalusAssetManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
