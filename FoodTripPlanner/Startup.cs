using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodTripPlanner.Startup))]
namespace FoodTripPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
