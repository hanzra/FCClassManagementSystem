using FCClassManagementSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using FCCClassManagementSystem.Domain.Entities;
using FCClassManagementSystem.Web.Models.ViewModels;

namespace FCClassManagementSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View(UserManager.Users);
        }

        public ActionResult Create()
        {
            return View(new NewAccountRegistration());
        }

        private AppUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
        }
    }
}