using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectje.Startup))]
namespace TestProjectje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
