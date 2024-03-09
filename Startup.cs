using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4_BigSchools.Startup))]
namespace A4_BigSchools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
