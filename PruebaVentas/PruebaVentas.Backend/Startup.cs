using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaVentas.Backend.Startup))]
namespace PruebaVentas.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
