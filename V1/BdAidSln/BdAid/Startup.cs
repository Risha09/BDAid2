using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BdAid.Startup))]
namespace BdAid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
