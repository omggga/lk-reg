using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lk_reg.Pages.Products
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Name = "Product 1", Price = 10 },
                new Product { Name = "Product 2", Price = 20 },
                new Product { Name = "Product 3", Price = 30 }
            };
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
