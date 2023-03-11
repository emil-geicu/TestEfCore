using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestProjectEF.Data;
using TestProjectEF.Data.DbModels;
using TestProjectEF.Models;

namespace TestProjectEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            _dbContext.Students.Add(new StudentDbModel()
            {
                Id=Guid.NewGuid(),
                Name="Emil"
            });
            _dbContext.SaveChanges();
            return View();
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