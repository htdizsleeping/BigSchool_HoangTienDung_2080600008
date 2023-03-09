using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangTienDung_2080600008_BigSchool.Startup))]
namespace HoangTienDung_2080600008_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
