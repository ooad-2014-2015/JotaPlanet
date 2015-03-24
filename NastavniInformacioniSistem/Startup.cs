using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NastavniInformacioniSistem.Startup))]
namespace NastavniInformacioniSistem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
