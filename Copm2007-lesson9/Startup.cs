using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Copm2007_lesson9.Startup))]
namespace Copm2007_lesson9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
