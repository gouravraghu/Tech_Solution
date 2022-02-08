using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechSolution.Startup))]
namespace TechSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
