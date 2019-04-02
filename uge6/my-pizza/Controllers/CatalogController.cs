using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_pizza.Models;

namespace my_pizza.Controllers
{
    public class CatalogController : Controller
    {
        private readonly CatalogContext _context;
        public CatalogController(CatalogContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id = 1)
        {
            var category = await Task.FromResult(_context.Categories.FirstOrDefault(x => x.Id == id));
            return View(category);
        }
    }
}