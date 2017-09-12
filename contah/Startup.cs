using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contah.Startup))]
namespace contah
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
