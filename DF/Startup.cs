using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DF.Startup))]
namespace DF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
