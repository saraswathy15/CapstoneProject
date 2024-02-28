using BlogTrackerWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CapstoneProject.Models;
using CapstoneProject.Data;
using Microsoft.EntityFrameworkCore;


namespace BlogTrackerWebapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CapstoneProjectDbContext _context;
        public HomeController(ILogger<HomeController> logger, CapstoneProjectDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _context.BlogInfo.ToListAsync();
            return View(blogs);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
