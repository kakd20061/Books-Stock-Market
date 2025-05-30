﻿using Books_Stock_Market.Areas.Identity.Pages.Account;
using Books_Stock_Market.Data;
using Books_Stock_Market.Data.Entities;
using Books_Stock_Market.Models.Dtos;
using Books_Stock_Market.Models.ViewModels;
using Books_Stock_Market.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;

namespace Books_Stock_Market.Controllers
{
    public class MarketController : Controller
    {
        private readonly IAnnouncementsViewModelProvider _AnnouncementsViewModelProvider;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly SignInManager<PageUser> _signInManager;
        private readonly UserManager<PageUser> _userManager;

        public MarketController(IAnnouncementsViewModelProvider AnnouncementsViewModelProvider, ApplicationDbContext dbContext, IWebHostEnvironment hostEnvironment, SignInManager<PageUser> signInManager, UserManager<PageUser> userManager)
        {
            _AnnouncementsViewModelProvider = AnnouncementsViewModelProvider;
            _dbContext = dbContext;
            _hostEnvironment = hostEnvironment;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Announcement()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var viewModel = _AnnouncementsViewModelProvider.PrepareAnnouncementsViewModel();
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AnnouncementManage()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

                var viewModel = _AnnouncementsViewModelProvider.PrepareAnnouncementsManageViewModel(user.Id);
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Add(AnnouncementsDto formData)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

                var viewModel = _AnnouncementsViewModelProvider.Add(formData, user.Id, user.PhoneNumber, user.Name, user.Email, false);
                return RedirectToAction("AnnouncementManage", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AddSubject(SubjectsDto subjectData)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var viewModel = _AnnouncementsViewModelProvider.AddSubject(subjectData);
                return RedirectToAction("AnnouncementManage", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Message(MessagesDto modalData, int Id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
                var announcement = _dbContext.Announcements.FirstOrDefault(x => x.Id == Id);
                var viewModel = _AnnouncementsViewModelProvider.AddMessage(modalData, user.Id, user.Email, Id, announcement.Title);
                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult MMessage(MMessagesDto modalData, int Id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
                var offers = _dbContext.Images.FirstOrDefault(x => x.Id == Id);
                var viewModel = _AnnouncementsViewModelProvider.AddMMessage(modalData, user.Id, user.Email, Id, offers.Title);
                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Respond(RespondMessagesDto respondData, int messageAnnId, bool isOffer)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (isOffer)
                {
                    var userName = User.Identity?.Name;
                    var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
                    var message = _dbContext.MMessage.FirstOrDefault(x => x.Id == messageAnnId);
                    var messager = message.UserForeignKey;
                    var fk = message.OffersForeignKey;
                    var author = _dbContext.Images.FirstOrDefault(x => x.Id == fk).pageUser;

                    var viewModel = _AnnouncementsViewModelProvider.Respond(respondData, author.Id, messager, author.Email, fk, "Re: " + message.Title, isOffer);

                    return RedirectToAction("Messages", "Market");
                }
                else
                {
                    var userName = User.Identity?.Name;
                    var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
                    var message = _dbContext.Messages.FirstOrDefault(x => x.Id == messageAnnId);
                    var messager = message.UserForeignKey;
                    var fk = message.AnnouncementForeignKey;
                    var author = _dbContext.Announcements.FirstOrDefault(x => x.Id == fk).pageUser;

                    var viewModel = _AnnouncementsViewModelProvider.Respond(respondData, author.Id, messager, author.Email, fk, "Re: " + message.Title, isOffer);

                    return RedirectToAction("Messages", "Market");
                }
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult RespondToRespond(RespondMessagesDto respondToRespondData, int messageId)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
                var message = _dbContext.RespondMessages.FirstOrDefault(x => x.Id == messageId);
                var user1 = _dbContext.Users.FirstOrDefault(x => x.Id == message.ToUser);
                var user2 = _dbContext.Users.FirstOrDefault(x => x.Id == message.FromUser);

                var viewModel = true;

                if (user.Id == user1.Id)
                {
                    viewModel = _AnnouncementsViewModelProvider.Respond(respondToRespondData, user1.Id, user2.Id, user1.Email, message.AnnouncementID, "Re: " + message.Title, message.IsOffer);
                }
                else if (user.Id == user2.Id)
                {
                    viewModel = _AnnouncementsViewModelProvider.Respond(respondToRespondData, user2.Id, user1.Id, user2.Email, message.AnnouncementID, "Re: " + message.Title, message.IsOffer);
                }
                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult DeleteIncoming(int id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var delete = _AnnouncementsViewModelProvider.Delete(id);

                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult DeleteMMessage(int id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var delete = _AnnouncementsViewModelProvider.DeleteMMessage(id);

                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult DeleteResponds(int id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var delete = _AnnouncementsViewModelProvider.DeleteRespond(id);

                return RedirectToAction("Messages", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
        public IActionResult DeleteAnnouncementAdmin(int id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var delete = _AnnouncementsViewModelProvider.Remove(id);

                return RedirectToAction("Announcement", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult DeleteOfferAdmin(int id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var delete = _AnnouncementsViewModelProvider.OfferRemove(id);

                return RedirectToAction("Marketplace", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Remove(int Id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var viewModel = _AnnouncementsViewModelProvider.Remove(Id);
                return RedirectToAction("AnnouncementManage", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult OfferRemove(int Id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var viewModel = _AnnouncementsViewModelProvider.OfferRemove(Id);
                return RedirectToAction("Offer", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Marketplace(string content = null, string type = null)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (content == null)
                {
                    if (type == null)
                    {
                        var viewModel = _AnnouncementsViewModelProvider.PrepareMarketplaceViewModel();
                        return View(viewModel);
                    }
                    else
                    {
                        var viewModel = _AnnouncementsViewModelProvider.PrepareMarketplaceWithOrderViewModel(type);
                        return View(viewModel);
                    }
                }
                else
                {
                    if (type == null)
                    {
                        var viewModel = _AnnouncementsViewModelProvider.PrepareMarketplaceWithSearchViewModel(content);
                        return View(viewModel);
                    }
                    else
                    {
                        var viewModel = _AnnouncementsViewModelProvider.PrepareMarketplaceWithOrderViewModel(type, content);
                        return View(viewModel);
                    }
                }
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Messages()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

                var viewModel = _AnnouncementsViewModelProvider.PrepareMessagesViewModel(user.Id);
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult Offer()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

                var viewModel = _AnnouncementsViewModelProvider.PrepareOfferViewModel(user.Id);
                return View(viewModel);
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

        public IActionResult AddPhoto(ImagesDto Image)
        {
            if (_signInManager.IsSignedIn(User))
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(Image.ImageFile.FileName);
                string extension = Path.GetExtension(Image.ImageFile.FileName);
                Image.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/img/OfferImages/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    Image.ImageFile.CopyTo(fileStream);
                }
                var userName = User.Identity?.Name;
                var user = _dbContext.Users.FirstOrDefault(x => x.UserName == userName);

                var photo = _AnnouncementsViewModelProvider.AddImage(Image, user.Id, user.Email);
                return RedirectToAction("Offer", "Market");
            }
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }
    }
}
