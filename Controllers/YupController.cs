using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLittleApp.Models;

namespace FirstLittleApp.Controllers
{
    public class YupController : Controller
    {
        // GET: Yup
        public ActionResult Index(string cool)
        {
            string c = HttpUtility.HtmlEncode(cool);
            if (c == "y")
            {
                ViewBag.Title = "This is the cool kids Page";
                return View("CoolKidsPage");
            }
            else
                ViewBag.Title = "This is not the cool kids Page";
            return View("CoolKidsPage");
        }

        [HttpPost]
        public ActionResult Form(string firstName, string lastName, bool koolKid)
        {
            KoolModel kid = new KoolModel()
            {
                firstName = firstName,
                lastName = lastName,
                koolKid = koolKid
            };
            bool k = koolKid;
            
            if (k == true)
            {
                ViewBag.Message = "Name: " + firstName + " " + lastName + " is a cool kid";
            }
            else
            {
                ViewBag.Message = "Name: " + firstName + " " + lastName + " is sooooo not a cool kid";
            }
            return View("Confirm", kid);
        }

        public ActionResult Form()
        {
            return View("MyForm");
        }

        public ActionResult Confirm()
        {
            return View("Confirm");
        }

        public ActionResult CoolKidList()
        {
            return View();
        }
        
    }
}