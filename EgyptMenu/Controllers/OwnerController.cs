using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgyptMenu.Controllers
{
    //[Authorize(Roles ="Owner")]
    public class OwnerController : Controller
    {
        // GET: Owner
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult QRBuilder()
        {
            return View();
        }
        public ActionResult Plan()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public new ActionResult Profile()
        {
            return View();
        }
        public ActionResult Restaurant()
        {
            return View();
        }

    }
}