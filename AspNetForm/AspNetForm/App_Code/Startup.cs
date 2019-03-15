using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetForm.Startup))]
namespace AspNetForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
