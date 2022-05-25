using JuanClasswork.DAL;
using JuanClasswork.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanClasswork.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Dictionary<string, string> settings = _context.settings.ToDictionary(d => d.Key, d => d.Value);
            HomeViewModel homeVM = new HomeViewModel
            {
                Settings = settings
            };
            return View(homeVM);
        }
    }
}
