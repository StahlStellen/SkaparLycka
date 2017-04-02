using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkapaStahlStellen.Startup))]
namespace SkapaStahlStellen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
