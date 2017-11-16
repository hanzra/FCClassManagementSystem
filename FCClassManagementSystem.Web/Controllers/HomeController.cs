using FCCClassManagementSystem.Domain.Entities;
using FCClassManagementSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FCClassManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Schedule> schedule = null;

            using (var db = new ApplicationDBContext())
            {
                schedule = db.Schedule.Include("FitnessClass").ToList();                
            }

            return View(schedule);
        }
    }
}