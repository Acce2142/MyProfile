using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyProfile.Core.Models;
using MyShop.Core.Contracts;
using MyShop.Core.Helpers;
using MyShop.Core.Models;
using MyShop.Core.ViewModels;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Profile> context;
        public HomeController(IRepository<Profile> profileContext)
        {
            context = profileContext;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            Email Email = new Email();
            return View(Email);
        }

        public ActionResult Contact(Email Email)
        {
            EmailHelper helper = new EmailHelper();
            helper.Send(Email.EmailAddress, Email.Body, Email.Title);
            return RedirectToAction("Index");
        }
    }
}