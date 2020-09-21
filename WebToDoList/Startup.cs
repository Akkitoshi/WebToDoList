using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebToDoList.Startup))]
namespace WebToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
