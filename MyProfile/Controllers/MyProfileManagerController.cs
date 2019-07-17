using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProfile.Core.Models;
using MyProfile.Models;
using MyShop.Core.Contracts;
using MyShop.Core.ViewModels;

namespace MyProfile.Controllers
{
    public class MyProfileManagerController : Controller
    {
        List<Profile> profiles = new List<Profile>();
        IRepository<Profile> context;
        // GET: MyProfileManager
        public ActionResult Index()
        {
            
            return View(profiles);
        }

        // GET: MyProfileManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyProfileManager/Create
        public ActionResult Create()
        {
           
           Profile profile = new Profile();
            return View(profile);
        }

        // POST: MyProfileManager/Create
        [HttpPost]
        public ActionResult Create(Profile profile, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine("done");
                    profiles.Add(profile);
                    return RedirectToAction("Index");
                }
                
                else
                {
                    return View(profile);
                }


                
            }
            catch
            {
                return View(profile);
            }
        }

        // GET: MyProfileManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyProfileManager/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyProfileManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyProfileManager/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
