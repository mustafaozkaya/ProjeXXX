using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjeXXX.Startup))]
namespace ProjeXXX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
