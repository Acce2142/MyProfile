using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProfile.Startup))]
namespace MyProfile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
