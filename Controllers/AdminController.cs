using ME_TOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ME_TOO.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.theUsers = CInstance.theUserManager.GetUsers();
            return View();
        }
        public ActionResult Candidate()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Key()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Key(CUser aUser)
        {
            int tmpBool;
            tmpBool = CInstance.theUserManager.AddUser(ref aUser);
            if (tmpBool == 1)
            {
                return (RedirectToAction("Index", aUser));
            }
            return View(aUser);
        }
        public ActionResult KeyOK(CUser aUser)
        {
            ViewBag.key = aUser.key;
            return View(aUser);
        }
        public ActionResult Result()
        {
            return View();
        }
        public ActionResult Clear()
        {
            return View();
        }
    }
}