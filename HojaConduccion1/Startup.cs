using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HojaConduccion1.Startup))]
namespace HojaConduccion1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
