using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.eShopWeb.Infrastructure.Identity;

namespace SimpleShop.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var adminUser = new ApplicationUser {UserName = "admin", Email = "admin@simpleshop.com"};
                var managerUser = new ApplicationUser {UserName = "manager", Email = "manager@simpleshop.com"};

                await userManager.CreateAsync(adminUser, "password");
                await userManager.CreateAsync(managerUser, "password");

                var adminClaim = new Claim("Role", "Admin");
                var managerClaim = new Claim("Role", "Manager");

                await userManager.AddClaimAsync(adminUser, adminClaim);
                await userManager.AddClaimAsync(managerUser, managerClaim);
            }
        }
    }
}