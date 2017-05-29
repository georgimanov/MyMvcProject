using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvcProject.Web.Startup))]
namespace MyMvcProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
