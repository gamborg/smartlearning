namespace my_pizza.ViewComponts
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using my_pizza.Models;

    public class ProductListViewComponent : ViewComponent
    {
        private readonly CatalogContext _context;
        public ProductListViewComponent(CatalogContext context) 
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var items = await GetProductsAsync(categoryId);
            return View(items);
        }

        private Task<List<Product>> GetProductsAsync(int categoryId)
        {
            return _context.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
        }
    }
}