using FrontLayiheDB.Data;
using FrontLayiheDB.Models;
using FrontLayiheDB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrontLayiheDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<Product> products = await _context.Products.ToListAsync();
            List<BasketProduct> basketProducts = await _context.BasketProducts.ToListAsync();

            HomeVM homeViewModels = new HomeVM
            {
                Sliders = sliders,
                Products = products,
                BasketProducts = basketProducts
            };
            return View(homeViewModels);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) return NotFound();
            BasketProduct dbproduct = await _context.BasketProducts.FindAsync(id);
            return Json(id);
        }
    }
}
