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
        FileTypes type = new FileTypes();
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
        public ActionResult Details(string id)
        {
            Profile profile = context.Find(id);
            if (profile != null)
            {
                return View(profile);
            }
            else
            {
                return HttpNotFound();
            }
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
                    if (type.ImageExtensions.Contains(Path.GetExtension(file.FileName).ToUpperInvariant()))
                    {
                        profile.Image = profile.Id + Path.GetExtension(file.FileName);
                        file.SaveAs(Server.MapPath("//Content//Image//") + profile.Image);
                        System.Diagnostics.Debug.WriteLine("File saved");
                        System.Diagnostics.Debug.WriteLine(profile.Image);
                    } else
                    {
                        return View(profile);
                    }
                } else
                {
                    profile.Image = "default.png";
                }
                System.Diagnostics.Debug.WriteLine(profile.Description);
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
        public ActionResult Edit(string id)
        {
            Profile ProfileToEdit = context.Find(id);
            System.Diagnostics.Debug.WriteLine(ProfileToEdit == null);
            if (ProfileToEdit != null)
            {
                System.Diagnostics.Debug.WriteLine("Not null 1");
                return View(ProfileToEdit);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: MyProfileManager/Edit/5
        [HttpPost]
        public ActionResult Edit(Profile profile, string Id, HttpPostedFileBase file)
        {
            Profile ProfileToEdit = context.Find(Id);
            
            if (ProfileToEdit != null)
            {
                
                if (ModelState.IsValid)
                {
                    
                    System.Diagnostics.Debug.WriteLine("done");
                    if (file != null)
                    {
                        if (type.ImageExtensions.Contains(Path.GetExtension(file.FileName).ToUpperInvariant()))
                        {
                            ProfileToEdit.Image = ProfileToEdit.Id + Path.GetExtension(file.FileName);
                            file.SaveAs(Server.MapPath("//Content//Image//") + ProfileToEdit.Image);
                            System.Diagnostics.Debug.WriteLine("File saved");
                        }
                        else
                        {
                            return View(profile);
                        }
                    } else
                    {
                        profile.Image = "default.png";
                    }

                    ProfileToEdit.FirstName = profile.FirstName;
                    ProfileToEdit.LastName = profile.LastName;
                    ProfileToEdit.PreferedName = profile.PreferedName;
                    ProfileToEdit.Email = profile.Email;
                    ProfileToEdit.Description = profile.Description;
                    context.Commit();
                    return RedirectToAction("Index");
                }

                else
                {
                    return View(profile);
                }
            }
            else
            {
                return HttpNotFound();
            }
        }

        // GET: MyProfileManager/Delete/5
        public ActionResult Delete(string id)
        {
            Profile ProfileToDelete = context.Find(id);
            if(ProfileToDelete != null)
            {
                return View(ProfileToDelete);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: MyProfileManager/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            Profile ProfileToDelete = context.Find(id);
            if(ProfileToDelete != null)
            {
                context.Delete(id);
                context.Commit();
                return RedirectToAction("Index");
            } else
            {
                return HttpNotFound();
            }

        }
    }
}
