using LOGIS.DAL;
using LOGIS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LOGIS.Controllers
{
    public class HomeController:Controller
    {
        readonly ProductDbContext _context;
        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            if (id == 0) return BadRequest();
            Product product = _context.Products.FirstOrDefault(p => p.Id == id)!;
            if (product is null) return NotFound();
            return View(product);
        }
    }
}
