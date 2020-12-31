using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleShop.ApplicationCore.Entities;
using SimpleShop.ApplicationCore.Interfaces;

namespace SimpleShop.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Product> Products { get; set; }
        
        public async Task OnGet([FromServices] IProductService productService)
        {
            Products =  await productService.GetAllProduct();
        }
    }
}
