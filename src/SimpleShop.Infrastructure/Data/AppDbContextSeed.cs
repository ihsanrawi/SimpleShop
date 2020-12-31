using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.ApplicationCore.Entities;

namespace SimpleShop.Infrastructure.Data
{
    public class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>
                {
                    new Product {Name = "White T-Shirt", Description = "A White T-Shirt", Price = 9.19M},
                    new Product {Name = "Black SweatShirt", Description = "A Black SweatShirt", Price = 23.39M},
                    new Product {Name = "Red Shirt", Description = "A Red Shirt", Price = 10.99M},
                    new Product {Name = "White Mug", Description = "A White Mug", Price = 4.49M},
                });
                
                await context.SaveChangesAsync();
            }
        }
    }
}