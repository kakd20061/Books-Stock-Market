using Books_Stock_Market.Models;
using Books_Stock_Market.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Books_Stock_Market.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult RegisterSummary(string password, string email)
        {
            return View(new RegisterSummaryViewModel() 
            { 
                password=password, 
                email=email
            });

        }

        public IActionResult About()
        {
            return View();
        }
    }
}