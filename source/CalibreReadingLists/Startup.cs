using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalibreReadingLists.Startup))]
namespace CalibreReadingLists
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
