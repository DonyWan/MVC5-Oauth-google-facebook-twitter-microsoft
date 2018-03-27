using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankTeach.Startup))]
namespace BankTeach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
