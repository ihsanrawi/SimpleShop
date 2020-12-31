using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleShop.ApplicationCore.Entities;
using SimpleShop.ApplicationCore.Interfaces;

namespace SimpleShop.Web.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }
        
        public async Task<RedirectToPageResult> OnPost([FromServices] IProductService productService)
        {
            await productService.AddNewProduct(Product);
            
            return RedirectToPage("/Index");
        }
    }
}