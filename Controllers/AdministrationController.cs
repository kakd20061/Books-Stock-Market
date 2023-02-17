using Books_Stock_Market.Areas.Identity.Pages.Account;
using Books_Stock_Market.Data;
using Books_Stock_Market.Models.Dtos;
using Books_Stock_Market.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;

namespace Books_Stock_Market.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IAdministrationViewModelProvider _administrationViewModelProvider;
        private readonly ApplicationDbContext _dbContext;
        private readonly SignInManager<PageUser> _signInManager;

        public AdministrationController(IAdministrationViewModelProvider adminstrationViewModelProvider, ApplicationDbContext dbContext, SignInManager<PageUser> signInManager)
        {
            _administrationViewModelProvider = adminstrationViewModelProvider;
            _dbContext = dbContext;
            _signInManager = signInManager;
        }

        public IActionResult AdminMain()
        {
            if(_administrationViewModelProvider.AdminReturn(User.Identity?.Name)&&_signInManager.IsSignedIn(User))
            {
                var viewModel = _administrationViewModelProvider.PrepareAdminMainViewModel();
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        public IActionResult SubjectEdit()
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var viewModel = _administrationViewModelProvider.PrepareSubjectsEditViewModel();
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AddSubject(SubjectsDto formData)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var add = _administrationViewModelProvider.AddSubject(formData);
                return RedirectToAction("SubjectEdit", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult DeleteSubject(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var reject = _administrationViewModelProvider.RejectSubject(Id);
                return RedirectToAction("SubjectEdit", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult RejectOffer(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var reject = _administrationViewModelProvider.RejectOffer(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AcceptOffer(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var accept = _administrationViewModelProvider.AcceptOffer(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Requests()
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var viewModel = _administrationViewModelProvider.PrepareRequestsViewModel();
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AdminManage()
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var viewModel = _administrationViewModelProvider.PrepareAdminManageViewModel();
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AcceptAnn(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var accept = _administrationViewModelProvider.AcceptAnnouncement(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult RejectAnn(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var reject = _administrationViewModelProvider.RejectAnnouncement(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AcceptSubject(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var accept = _administrationViewModelProvider.AcceptSubject(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult RejectSubject(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var reject = _administrationViewModelProvider.RejectSubject(Id);
                return RedirectToAction("Requests", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AddAdminGrands(AdministrationDto formData)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var add = _administrationViewModelProvider.AddAdminGrands(formData);
                return RedirectToAction("AdminManage", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult RemoveAdminGrands(int Id)
        {
            if (_administrationViewModelProvider.AdminReturn(User.Identity?.Name) && _signInManager.IsSignedIn(User))
            {
                var add = _administrationViewModelProvider.RemoveAdminGrands(Id);
                return RedirectToAction("AdminManage", "Administration");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
    }
}
