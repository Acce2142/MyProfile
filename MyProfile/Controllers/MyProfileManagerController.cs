using System;
using System.Collections.Generic;
using System.IO;
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

        IRepository<Profile> context;
        public MyProfileManagerController(IRepository<Profile> profileContext)
        {
            context = profileContext;
        }
        // GET: MyProfileManager
        public ActionResult Index()
        {

            List<Profile> profiles = context.Collection().ToList();
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
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("done");
                if (file != null)
                {
                    profile.Image = profile.Id + Path.GetExtension(file.FileName);
                    file.SaveAs(Server.MapPath("//Content//Image//") + profile.Image);
                    System.Diagnostics.Debug.WriteLine("File saved");
                    System.Diagnostics.Debug.WriteLine(profile.Image);
                }
                context.Insert(profile);
                context.Commit();
                return RedirectToAction("Index");
            }

            else
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
