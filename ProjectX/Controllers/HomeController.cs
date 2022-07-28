using ProjectX.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ProjectX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string address)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Summary", new { name, address });
            }
            return View();
        }

        public ActionResult Summary(string name, string address)
        {
            User user = new User() { Name = name, Address = address };
            return View(user);
        }

        public ActionResult SwitchCulture(bool culture)
        {
            if (culture != null)
            {
                if (culture)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    Session["culture"] = "en-GB";
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                    Session["culture"] = "pl-PL";
                }
            }
            return View("index");
        }
    }
}