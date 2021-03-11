using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoInventario.Startup))]
namespace ProyectoInventario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
