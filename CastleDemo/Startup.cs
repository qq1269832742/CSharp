using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CastleDemo.Startup))]
namespace CastleDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
