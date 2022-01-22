using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult ClientView()
        {
            return View();
        }
        public ActionResult MenuView()
        {
            return View();
        }

        public ActionResult MenuincView()
        {
            return View();
        }

        public ActionResult MenudecView()
        {
            return View();
        }

        public ActionResult MenupopView()
        {
            return View();
        }
        public ActionResult SigninView()
        {
            return View();
        }
        public ActionResult CreateAccView()
        {
            return View();
        }
        public ActionResult RegistrationView()
        {

            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegistrationViewModel model)
        {
            CoffeeShopEntities2 db = new CoffeeShopEntities2();

            SiteUser siteUser = new SiteUser();
            siteUser.Username = model.Username;
            siteUser.Email = model.Email;
            siteUser.Password = model.Password;
            siteUser.Country = model.Country;
            siteUser.RoleID = 2;

            db.SiteUser.Add(siteUser);
            db.SaveChanges();

            return View(); 
        }

        public ActionResult BaristaView()
        {

            return View();
        }

        public ActionResult AdminView()
        {

            return View();
        }
        public ActionResult AboutView()
        {

            return View();
        }
        public ActionResult PaymentView()
        {

            return View();
        }

    }
}