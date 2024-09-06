using APPR_PART_2.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APPR_PART_2.Controllers
{
    public class ProductController : Controller
    {
        private readonly DBContextSample _context;

        public ProductController(DBContextSample context)
        {
            _context = context;
        }

        public IActionResult Show(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                return View(product);
            }
            else
            {
                return NotFound();
            }
        }
    }
}