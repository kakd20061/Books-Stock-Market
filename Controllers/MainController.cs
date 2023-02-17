using Books_Stock_Market.Areas.Identity.Pages.Account;
using Books_Stock_Market.Models;
using Books_Stock_Market.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Books_Stock_Market.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;
        private readonly SignInManager<PageUser> _signInManager;
        private readonly UserManager<PageUser> _userManager;

        public MainController(ILogger<MainController> logger, SignInManager<PageUser> signInManager, UserManager<PageUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult RegisterSummary(string password, string email)
        {
            if(_signInManager.IsSignedIn(User))
            {
                return View(new RegisterSummaryViewModel()
                {
                    password = password,
                    email = email
                });
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult About()
        {
            return View();
        }
    }
}