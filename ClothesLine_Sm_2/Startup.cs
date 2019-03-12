using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothesLine_Sm_2.Startup))]
namespace ClothesLine_Sm_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
