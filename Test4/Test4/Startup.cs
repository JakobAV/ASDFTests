using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test4.Startup))]
namespace Test4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
