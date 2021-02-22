using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicRadioStore.WebUI.Startup))]
namespace MusicRadioStore.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
