using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyProfile.Core.Models;
using MyShop.Core.Contracts;
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
            List<Profile> profiles = context.Collection().ToList();
            return View(profiles);
        }
    }
}