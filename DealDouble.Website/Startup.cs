using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealDouble.Website.Startup))]
namespace DealDouble.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
