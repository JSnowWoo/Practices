using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beisen.PracticeProject.Web.Startup))]
namespace Beisen.PracticeProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
