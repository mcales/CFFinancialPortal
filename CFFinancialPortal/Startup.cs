using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CFFinancialPortal.Startup))]
namespace CFFinancialPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
