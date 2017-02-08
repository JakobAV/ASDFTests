using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test5.Startup))]
namespace Test5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
