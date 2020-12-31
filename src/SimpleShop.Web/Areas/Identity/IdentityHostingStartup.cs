using Microsoft.AspNetCore.Hosting;
using SimpleShop.Web.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]
namespace SimpleShop.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}