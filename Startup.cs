using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicWorld.Startup))]
namespace MusicWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
