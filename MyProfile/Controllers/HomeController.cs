using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MyProfile.Core.Models;
using MyShop.Core.ViewModels;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}