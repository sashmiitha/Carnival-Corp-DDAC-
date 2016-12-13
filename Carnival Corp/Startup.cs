using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carnival_Corp.Startup))]
namespace Carnival_Corp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
