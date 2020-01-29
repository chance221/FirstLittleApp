using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstLittleApp.Startup))]
namespace FirstLittleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
