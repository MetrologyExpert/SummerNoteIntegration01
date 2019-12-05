using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummerNoteIntegration01.Startup))]
namespace SummerNoteIntegration01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
