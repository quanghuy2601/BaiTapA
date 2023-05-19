using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTapA.Startup))]
namespace BaiTapA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
