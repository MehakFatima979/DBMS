using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbms.Startup))]
namespace dbms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
