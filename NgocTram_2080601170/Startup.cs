using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NgocTram_2080601170.Startup))]
namespace NgocTram_2080601170
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
