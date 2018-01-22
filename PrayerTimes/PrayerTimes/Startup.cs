using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrayerTimes.Startup))]
namespace PrayerTimes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
