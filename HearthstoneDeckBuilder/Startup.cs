using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HearthstoneDeckBuilder.Startup))]
namespace HearthstoneDeckBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
