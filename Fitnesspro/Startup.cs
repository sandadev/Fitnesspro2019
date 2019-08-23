using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fitnesspro.Startup))]
namespace Fitnesspro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
