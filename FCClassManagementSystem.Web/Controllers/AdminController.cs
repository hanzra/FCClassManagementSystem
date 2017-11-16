using FCCClassManagementSystem.Domain.Entities;
using FCClassManagementSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FCClassManagementSystem.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (var db = new ApplicationDBContext())
            {
                return View(db.FitnessClass.ToList());
            }
        }

        public ActionResult CreateClass()
        {
            return View(new FitnessClass());
        }
        [HttpPost]
        public ActionResult CreateClass(FitnessClass fitnessClass)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ApplicationDBContext())
                {
                    db.FitnessClass.Add(fitnessClass);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                
            }

            return View(fitnessClass);
            
        }

        public ActionResult ScheduleList()
        {
            using (var db = new ApplicationDBContext())
            {
                var schedule = db.Schedule.Include("FitnessClass").ToList();
                return View(schedule);
            }
        }

        public ActionResult CreateSchedule()
        {
            using (var db = new ApplicationDBContext())
            {
                ViewBag.FitnessClassName = db.FitnessClass.ToList();
            }
            return View();
        }
        [HttpPost]
        public ActionResult CreateSchedule(Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                using (var db  = new ApplicationDBContext())
                {
                    db.Schedule.Add(schedule);
                    db.SaveChanges();
                }

                return RedirectToAction("ScheduleList");
            }

            return View(schedule);
        }
    }
}