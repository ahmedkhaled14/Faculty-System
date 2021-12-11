using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstwebapp.Startup))]
namespace firstwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
