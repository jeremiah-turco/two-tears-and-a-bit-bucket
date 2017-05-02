using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitVSIntegration.Startup))]
namespace TestGitVSIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
