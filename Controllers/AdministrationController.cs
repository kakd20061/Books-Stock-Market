using Books_Stock_Market.Data;
using Books_Stock_Market.Models.Dtos;
using Books_Stock_Market.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books_Stock_Market.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IAdministrationViewModelProvider _administrationViewModelProvider;
        private readonly ApplicationDbContext _dbContext;


        public AdministrationController(IAdministrationViewModelProvider adminstrationViewModelProvider, ApplicationDbContext dbContext)
        {
            _administrationViewModelProvider = adminstrationViewModelProvider;
            _dbContext = dbContext;
        }

        public IActionResult AdminMain()
        {
            var viewModel = _administrationViewModelProvider.PrepareAdminMainViewModel();
            return View(viewModel);
        }

        public IActionResult EditOffer()
        {
            return View();
        }
        public IActionResult SubjectEdit()
        {
            var viewModel = _administrationViewModelProvider.PrepareSubjectsEditViewModel();
            return View(viewModel);
        }

        public IActionResult AddSubject(SubjectsDto formData)
        {
            var add = _administrationViewModelProvider.AddSubject(formData);
            return RedirectToAction("SubjectEdit", "Administration");
        }

        public IActionResult DeleteSubject(int Id)
        {
            var reject = _administrationViewModelProvider.RejectSubject(Id);
            return RedirectToAction("SubjectEdit", "Administration");
        }

        public IActionResult RejectOffer(int Id)
        {
            var reject = _administrationViewModelProvider.RejectOffer(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult AcceptOffer(int Id)
        {
            var accept = _administrationViewModelProvider.AcceptOffer(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult Requests()
        {
            var viewModel = _administrationViewModelProvider.PrepareRequestsViewModel();
            return View(viewModel);
        }

        public IActionResult AdminManage()
        {
            var viewModel = _administrationViewModelProvider.PrepareAdminManageViewModel();
            return View(viewModel);
        }

        public IActionResult AcceptAnn(int Id)
        {
            var accept = _administrationViewModelProvider.AcceptAnnouncement(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult RejectAnn(int Id)
        {
            var reject = _administrationViewModelProvider.RejectAnnouncement(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult AcceptSubject(int Id)
        {
            var accept = _administrationViewModelProvider.AcceptSubject(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult RejectSubject(int Id)
        {
            var reject = _administrationViewModelProvider.RejectSubject(Id);
            return RedirectToAction("Requests", "Administration");
        }

        public IActionResult AddAdminGrands(AdministrationDto formData)
        {
            var add = _administrationViewModelProvider.AddAdminGrands(formData);
            return RedirectToAction("AdminManage", "Administration");
        }

        public IActionResult RemoveAdminGrands(int Id)
        {
            var add = _administrationViewModelProvider.RemoveAdminGrands(Id);
            return RedirectToAction("AdminManage", "Administration");
        }
    }
}
